using Blog.Contracts;
using Blog.Contracts.Responses;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    public class TagController : BaseController
    {
        private readonly ITagService _service;

        public TagController(ITagService service)
        {
            _service = service;
        }

        [HttpGet, Route(ApiRoutes.Tags.Get)]
        [ProducesResponseType(typeof(TagResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _service.GetAsync();
            return Ok(response);
        }
    }
}
