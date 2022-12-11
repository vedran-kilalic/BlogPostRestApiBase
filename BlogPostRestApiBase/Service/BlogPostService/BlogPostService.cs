using BlogPostRestApiBase.Models;

namespace BlogPostRestApiBase.Service.BlogPostService
{
    public class BlogPostService : IBlogPostService
    {
        private static List<BlogPost> blogPost = new List<BlogPost>
        {
            new BlogPost
            {
                slug = "augmented-reality-ios-application",
                title = "Augmented Reality android Application",
                description = "Rubicon Sowtware Development and Hifa Oil are proud to lunch our new demo",
                body = "The app is a bit simplified , and will help you decide where to tank your gas",
                tagList = {"AR", "iOS" } ,
                createdAt = "2019-07-18T03:23:48.984M",
                updatedAt = "2019-07-18T03:23:48.857L",


            },
            new BlogPost
            {
                slug = "augmented-reality-ios-application-drive",
                title = "Augmented Reality iOS Application Drive",
                description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                body = "The app is simple to use, and will help you decide on your best furniture fit.",
                tagList = {"AR", "iOS" } ,
                createdAt = "2018-05-18T03:22:56.637Z",
                updatedAt = "2018-05-18T03:48:35.824Z",
            }
       };
        public List<BlogPost> AddBlogPost(BlogPost blogposts)
        {
            blogPost.Add(blogposts);
            return blogPost;
        }

        public List<BlogPost>? DeleteBlogPost(String slug)
        {
            var blogpost = blogPost.Find(x => x.slug == slug);
            if (blogpost is null)
                return null;

            blogPost.Remove(blogpost);
            return blogPost;

        }

        public List<BlogPost> GetAllBlogPosts()
        {
            return blogPost;
        }

        public BlogPost GetSingleBlogPost(String slug)
        {
            var blogposts = blogPost.Find(x => x.slug == slug);
            if (blogposts is null)
                return null;
            return null;
        }

        public List<BlogPost>? UpdateBlogPost(String slug, BlogPost request)
        {
            var blogposts = blogPost.Find(x => x.slug == slug);
            if (blogposts is null)
                return null;

            blogposts.title = request.title;
            blogposts.description = request.description;
            blogposts.body = request.body;
            blogposts.tagList = request.tagList;
            blogposts.createdAt = request.createdAt;
            blogposts.updatedAt = request.updatedAt;
            return blogPost;
        }

    }

}

