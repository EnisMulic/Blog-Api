using System.Collections.Generic;

namespace Blog.Contracts.Responses
{
    public class TagResponse : Response
    {
        public List<string> Tags { get; set; }
    }
}
