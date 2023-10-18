public class BlogPostDTO
{
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Slug { get; set; }
    public required string ImageUrl { get; set; }
    public required string Markdown { get; set; }

    public required string AuthorName { get; set; }
    public required string AuthorUsername { get; set; }
    public required string AuthorImageUrl { get; set; }

    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}
