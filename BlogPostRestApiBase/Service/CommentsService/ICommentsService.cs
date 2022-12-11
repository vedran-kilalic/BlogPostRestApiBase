using BlogPostRestApiBase.Models;

namespace BlogPostRestApiBase.Service.CommentsService
{
    public interface ICommentsService
    {
        List<Comments> GetAllComments();
        Comments GetSingleComment(int id);
        List<Comments>? AddComments(Comments comment);
        List<Comments>? UpdateComment(int id, Comments request);
        List<Comments>? DeleteComment(int id);
    }
}
