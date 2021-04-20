using Blog.Contracts;
using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet, Route(ApiRoutes.Posts.Get)]
        [ProducesResponseType(typeof(PostsResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync([FromQuery] SearchPostRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpGet, Route(ApiRoutes.Posts.GetBySlug)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetBySlugAsync(string slug)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route(ApiRoutes.Posts.Create)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesErrorResponseType(typeof(ErrorResponse))]
        public async Task<IActionResult> CreateAsync(CreatePostRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPut, Route(ApiRoutes.Posts.Update)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesErrorResponseType(typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateAsync(string slug, UpdatePostRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpDelete, Route(ApiRoutes.Posts.Delete)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteAsync(string slug)
        {
            throw new NotImplementedException();
        }
    }
}
