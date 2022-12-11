namespace BlogPostRestApiBase.Models
{
    public class BlogPost
    {
        public String slug { get; set; } = string.Empty;
        public String title { get; set; } = string.Empty;
        public String description { get; set; } = string.Empty;
        public String body { get; set; } = string.Empty;

        public List<String> tagList { get; set; } = new List<String>();
        public String createdAt { get; set; } = string.Empty;
        public String updatedAt { get; set; } = string.Empty;
    }
}
