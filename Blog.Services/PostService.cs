using AutoMapper;
using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using Blog.Core.Helpers;
using Blog.Database;
using Blog.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class PostService : IPostService
    {
        private readonly BlogDbContext _context;
        private readonly IMapper _mapper;

        public PostService(BlogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Response> GetAsync(SearchPostRequest request)
        {
            var query = _context.Posts.AsQueryable();

            query = ApplyInclude(query);
            query = query.OrderByDescending(i => i.CreatedAt);
            query = ApplyFilter(query, request);

            var list = await query.ToListAsync();

            var response = _mapper.Map<List<PostModel>>(list);

            return new PostsResponse
            {
                BlogPosts = response,
                PostsCount = response.Count
            };
        }
        public async Task<Response> GetBySlugAsync(string slug)
        {
            var query = _context.Posts.AsQueryable();
            query = ApplyInclude(query);

            var post = await query.SingleOrDefaultAsync(i => i.Slug == slug);

            if (post == null)
            {
                return null;
            }

            var response = _mapper.Map<PostModel>(post);

            return new PostResponse
            {
                BlogPost = response
            };
        }

        public async Task<Response> CreateAsync(CreatePostRequest request)
        {
            var slug = SlugHelper.GenerateSlug(request.BlogPost.Title);

            var post = await _context.Posts.SingleOrDefaultAsync(i => i.Slug == slug);

            if(post != null)
            {
                var error = new ErrorModel
                {
                    Message = $"The blog post {request.BlogPost.Title} already exists"
                };

                return new ErrorResponse(error);
            }

            post = _mapper.Map<Post>(request.BlogPost);
            post.Slug = slug;

            await _context.AddAsync(post);
            await _context.SaveChangesAsync();

            foreach (var item in request.BlogPost.TagList)
            {
                var tag = await _context.Tags.SingleOrDefaultAsync(i => i.Name == item);

                if (tag == null)
                {
                    tag = new Tag
                    {
                        Name = item
                    };
                }

                post.PostTags.Add(new PostTag
                {
                    Post = post,
                    Tag = tag
                });
            }

            await _context.SaveChangesAsync();

            var response = _mapper.Map<PostModel>(post);

            return new PostResponse
            {
                BlogPost = response
            };
        }

        public async Task<Response> UpdateAsync(string slug, UpdatePostRequest request)
        {
            var query = _context.Posts.AsQueryable();
            query = ApplyInclude(query);

            var post = await query.SingleOrDefaultAsync(i => i.Slug == slug);

            if (post == null)
            {
                return null;
            }

            _context.Posts.Attach(post);
            _context.Posts.Update(post);

            _mapper.Map(request.BlogPost, post);

            if(!string.IsNullOrEmpty(request.BlogPost.Title))
            {
                post.Slug = SlugHelper.GenerateSlug(request.BlogPost.Title);
            }

            _context.Update(post);
            await _context.SaveChangesAsync();

            var response = _mapper.Map<PostModel>(post);

            return new PostResponse
            {
                BlogPost = response
            };
        }

        public async Task<bool> DeleteAsync(string slug)
        {
            var post = await _context.Posts.SingleOrDefaultAsync(i => i.Slug == slug);

            if(post == null)
            {
                return false;
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return true;
        }

        private IQueryable<Post> ApplyInclude(IQueryable<Post> query)
        {
            return query.Include(i => i.PostTags)
                .ThenInclude(i => i.Tag);
        }

        private IQueryable<Post> ApplyFilter(IQueryable<Post> query, SearchPostRequest request)
        {
            if (!string.IsNullOrWhiteSpace(request.Tag))
            {
                query = query.Where(i => i.PostTags.Select(i => i.Tag.Name).Contains(request.Tag));
            }

            return query;
        }
    }
}
