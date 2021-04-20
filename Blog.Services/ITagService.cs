using Blog.Contracts.Responses;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface ITagService
    {
        Task<Response> GetAsync();
    }
}
