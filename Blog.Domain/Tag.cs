using System.Collections.Generic;

namespace Blog.Domain
{
    public class Tag : Entity
    {
        public string Name { get; set; }
        public List<PostTag> PostTags { get; set; } = new();
    }
}