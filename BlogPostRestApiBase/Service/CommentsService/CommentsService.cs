using BlogPostRestApiBase.Models;

namespace BlogPostRestApiBase.Service.CommentsService
{
    public class CommentsService:ICommentsService
    {
        private static List<Comments> comments = new List<Comments>
        {
            new Comments
            {
                Id= 1,
                createdAt = "2018-04-18T03:22:56.637Z",
                updatedAt = "2018-04-18T03:22:56.637Z",
                Body = "Great Blog"
            },
            new Comments
            {
                Id = 2,
                createdAt = "2018-05-19T03:23:28.456Z",
                updatedAt = "2018-05-19T03:23:28.456Z",
                Body = "Excellent Blog"
            }
        };
        public List<Comments>? AddComments(Comments comment)
        {
            comments.Add(comment);
            return comments;
        }

        public List<Comments>? DeleteComment(int id)
        {
            var comment = comments.Find(x => x.Id == id);
            if (comment is null)
                return null;

            comments.Remove(comment);
            return comments;
        }

        public List<Comments> GetAllComments()
        {
            return (comments);
        }

        public Comments GetSingleComment(int id)
        {
            var comment = comments.Find(x => x.Id == id);
            if (comment is null)
                return null;
            return comment;
        }

        public List<Comments>? UpdateComment(int id, Comments request)
        {
            var comment = comments.Find(x => x.Id == id);
            if (comment is null)
                return null;

            comment.createdAt = request.createdAt;
            comment.updatedAt = request.updatedAt;
            comment.Body = request.Body;
            return comments;
        }


    }
}
    

