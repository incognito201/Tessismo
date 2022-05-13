using Microsoft.AspNetCore.Mvc;
using TessismoWebApi.Infra;
using TessismoWebApi.Models;

namespace TessismoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : Controller
    {
        private readonly TessismoDbContext _context;

        public PostsController(TessismoDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void InsertPost(Post post)
        {
            _context.Add(post);
            _context.SaveChanges();
        }

        [HttpGet]
        public ICollection<Post> GetPosts()
        {
            var posts = _context.Posts.ToList();
            return posts;
        }
    }
}
