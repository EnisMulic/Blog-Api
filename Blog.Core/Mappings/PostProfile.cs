using AutoMapper;
using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using Blog.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Core.Mappings
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostModel>()
                .ForMember(dest => dest.TagList, opt => opt.MapFrom<TagsListResolver>());
            CreateMap<CreatePostModel, Post>();
            CreateMap<UpdatePostModel, Post>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }

        private class TagsListResolver : IValueResolver<Post, PostModel, IEnumerable<string>>
        {
            public IEnumerable<string> Resolve(Post source, PostModel destination, IEnumerable<string> destMember, ResolutionContext context)
            {
                return source.PostTags.Select(i => i.Tag.Name).ToList();
            }
        }
    }
}
