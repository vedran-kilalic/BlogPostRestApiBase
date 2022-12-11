namespace BlogPostRestApiBase.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public String createdAt { get; set; } = string.Empty;
        public String updatedAt { get; set; } = string.Empty;
        public String Body { get; set; } = string.Empty;
    }
}
