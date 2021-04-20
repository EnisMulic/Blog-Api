using Blog.Contracts.Requests;
using Blog.Contracts.Responses;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IPostService
    {
        Task<Response> GetAsync(SearchPostRequest request);
        Task<Response> GetBySlugAsync(string slug);
        Task<Response> CreateAsync(CreatePostRequest request);
        Task<Response> UpdateAsync(string slug, UpdatePostRequest request);
        Task<bool> DeleteAsync(string slug);
    }
}
