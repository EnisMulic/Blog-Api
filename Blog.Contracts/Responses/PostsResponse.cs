using System.Collections.Generic;

namespace Blog.Contracts.Responses
{
    public class PostsResponse : Response
    {
        public List<PostModel> BlogPosts { get; set; }
        public int PostsCount { get; set; }
    }
}
