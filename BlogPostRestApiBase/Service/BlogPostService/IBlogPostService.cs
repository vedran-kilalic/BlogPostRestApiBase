using BlogPostRestApiBase.Models;

namespace BlogPostRestApiBase.Service.BlogPostService
{
    public interface IBlogPostService
    {
        List<BlogPost> GetAllBlogPosts();
        BlogPost GetSingleBlogPost(String slug);
        List<BlogPost>? AddBlogPost(BlogPost blogPost);
        List<BlogPost>? UpdateBlogPost(String slug, BlogPost request);
        List<BlogPost>? DeleteBlogPost(String slug);
    }
}
