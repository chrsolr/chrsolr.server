using System.ComponentModel.DataAnnotations.Schema;

public class BlogPost
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Slug { get; set; }
    public required string ImageUrl { get; set; }
    public required string Markdown { get; set; }
    public required bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }
    public User User { get; set; }
}