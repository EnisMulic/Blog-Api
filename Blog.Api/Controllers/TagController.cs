using Blog.Contracts;
using Blog.Contracts.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [ApiController]
    public class TagController : ControllerBase
    {
        [HttpGet, Route(ApiRoutes.Tags.Get)]
        [ProducesResponseType(typeof(TagResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
