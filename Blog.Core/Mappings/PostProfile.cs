using AutoMapper;
using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using Blog.Domain;

namespace Blog.Core.Mappings
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostModel>();
            CreateMap<CreatePostModel, Post>();
            CreateMap<UpdatePostModel, Post>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
