using System.Collections.Generic;

namespace Blog.Domain
{
    public class Post : Entity
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public List<PostTag> PostTags { get; set; } = new();
    }
}
