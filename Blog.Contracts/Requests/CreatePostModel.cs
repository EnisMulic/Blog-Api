using System.Collections.Generic;

namespace Blog.Contracts.Requests
{
    public class CreatePostModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
