using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Blog.Api.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    public class BaseController : ControllerBase
    {
    }
}
