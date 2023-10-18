using System.ComponentModel.DataAnnotations.Schema;

public class BlogPost
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Slug { get; set; }
    public required string ImageUrl { get; set; }
    public required string Markdown { get; set; }
    public required bool IsActive { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    [ForeignKey("User")]
    public required Guid UserId { get; set; }
    public User User { get; set; }
}
