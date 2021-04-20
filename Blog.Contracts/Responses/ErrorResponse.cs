using System.Collections.Generic;

namespace Blog.Contracts.Responses
{
    public class ErrorResponse : Response
    {
        public ErrorResponse()
        { }
        public ErrorResponse(ErrorModel error)
        {
            Errors.Add(error);
        }
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}
