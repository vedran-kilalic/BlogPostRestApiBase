using BlogPostRestApiBase.Models;
using BlogPostRestApiBase.Service.BlogPostService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostRestApiBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet]
        public async Task<ActionResult<List<BlogPost>>> GetAllBlogPosts()
        {
            var result = _blogPostService.GetAllBlogPosts();
            return Ok(result);
        }
        [HttpGet("{slug}")]
        public async Task<ActionResult<BlogPost>> GetSingleBlogPost(String slug)
        {
            var result = _blogPostService.GetSingleBlogPost(slug);
            if (result is null)
                return NotFound("Blog not Found");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<BlogPost>>> AddBlogPost(BlogPost blogPost)
        {
            var result = _blogPostService.AddBlogPost(blogPost);
            return Ok(result);
        }
        [HttpPut("{slug}")]
        public async Task<ActionResult<List<BlogPost>>> UpdateBlogPost(String slug, BlogPost request)
        {
            var result = _blogPostService.UpdateBlogPost(slug, request);
            if (result is null)
                return NotFound("Blog is not found");
            return Ok(result);
        }
        [HttpDelete("{slug}")]
        public async Task<ActionResult<List<BlogPost>>> DeleteBlogPost(String slug)
        {
            var result = _blogPostService.DeleteBlogPost(slug);
            if (result is null)
                return NotFound("Blog is not found");
            return Ok(result);
        }
    }
}

