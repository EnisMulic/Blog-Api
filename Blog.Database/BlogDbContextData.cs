using Blog.Domain;
using Bogus;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Blog.Database
{
    public partial class BlogDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            var tagFaker = new Faker<Tag>()
                .RuleFor(i => i.Name, i => i.Lorem.Word())
                .RuleFor(i => i.CreatedAt, i => i.Date.Past())
                .RuleFor(i => i.UpdatedAt, i => i.Date.Recent());

            var postFaker = new Faker<Post>()
                .RuleFor(i => i.Slug, i => i.Lorem.Slug())
                .RuleFor(i => i.Title, i => i.Lorem.Sentence())
                .RuleFor(i => i.Description, i => i.Lorem.Paragraph())
                .RuleFor(i => i.Body, i => i.Lorem.Paragraph())
                .RuleFor(i => i.CreatedAt, i => i.Date.Past())
                .RuleFor(i => i.UpdatedAt, i => i.Date.Recent());

            var tags = new List<Tag>();
            for(int i = 1; i <= 10; i++)
            {
                var tag = tagFaker.Generate();
                tag.Id = i;
                tags.Add(tag);
            }

            var posts = new List<Post>();
            for(int i = 1; i <= 10; i++)
            {
                var post = postFaker.Generate();
                post.Id = i;
                posts.Add(post);
            }

            var postTags = new List<PostTag>();
            for(int i = 1; i <= 10; i++)
            {
                var postTag = new PostTag
                {
                    PostId = i,
                    TagId = i
                };
                postTags.Add(postTag);
            }

            postTags.Add(new PostTag
            {
                PostId = 2,
                TagId = 1
            });

            modelBuilder.Entity<Tag>()
                .HasData(tags);

            modelBuilder.Entity<Post>()
                .HasData(posts);

            modelBuilder.Entity<PostTag>()
                .HasData(postTags);
        }
    }
}
