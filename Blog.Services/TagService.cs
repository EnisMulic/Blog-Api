using AutoMapper;
using Blog.Contracts.Responses;
using Blog.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class TagService : ITagService
    {
        private readonly BlogDbContext _context;

        public TagService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<Response> GetAsync()
        {
            var list = await _context.Tags
                .Select(i => i.Name)
                .ToListAsync();

            return new TagResponse
            {
                Tags = list
            };
        }
    }
}
