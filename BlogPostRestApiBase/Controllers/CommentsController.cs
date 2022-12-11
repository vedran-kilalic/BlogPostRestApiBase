using BlogPostRestApiBase.Models;
using BlogPostRestApiBase.Service.CommentsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostRestApiBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
  public class CommentsController : ControllerBase
    {

        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comments>>> GetAllComments()
        {
            var result = _commentsService.GetAllComments();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Comments>> GetSingleComment(int id)
        {
            var result = _commentsService.GetSingleComment(id);
            if (result is null)
                return NotFound("Hero not Found");
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<List<Comments>>> AddComments(Comments comments)
        {
            var result = _commentsService.AddComments(comments);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Comments>>> UpdateComment(int id, Comments request)
        {
            var result = _commentsService.UpdateComment(id, request);
            if (result is null)
                return NotFound("Hero is not found");
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Comments>>> DeleteComment(int id)
        {
            var result = _commentsService.DeleteComment(id);
            if (result is null)
                return NotFound("Hero is not found");
            return Ok(result);
        }
    }
}
