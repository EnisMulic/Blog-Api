using Blog.Contracts;
using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;

        public PostController(IPostService service)
        {
            _service = service;
        }

        [HttpGet, Route(ApiRoutes.Posts.Get)]
        [ProducesResponseType(typeof(PostsResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync([FromQuery] SearchPostRequest request)
        {
            var response = await _service.GetAsync(request);
            return Ok(response);
        }

        [HttpGet, Route(ApiRoutes.Posts.GetBySlug)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetBySlugAsync(string slug)
        {
            var response = await _service.GetBySlugAsync(slug);

            if(response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost, Route(ApiRoutes.Posts.Create)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesErrorResponseType(typeof(ErrorResponse))]
        public async Task<IActionResult> CreateAsync(CreatePostRequest request)
        {
            var response = await _service.CreateAsync(request);

            if(response is ErrorResponse)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPut, Route(ApiRoutes.Posts.Update)]
        [ProducesResponseType(typeof(PostResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesErrorResponseType(typeof(ErrorResponse))]
        public async Task<IActionResult> UpdateAsync(string slug, UpdatePostRequest request)
        {
            var response = await _service.UpdateAsync(slug, request);

            if(response == null)
            {
                return NotFound();
            }

            if (response is ErrorResponse)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpDelete, Route(ApiRoutes.Posts.Delete)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> DeleteAsync(string slug)
        {
            var response = await _service.DeleteAsync(slug);

            if (!response)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
