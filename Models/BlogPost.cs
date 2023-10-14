using System.ComponentModel.DataAnnotations.Schema;

public class BlogPost : IAudit
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public required string Slug { get; set; }
    public required string ImageUrl { get; set; }
    public required string Markdown { get; set; }
    public required bool IsActive { get; set; }
    
    [NotMapped]
    public DateOnly CreatedAt { get; set; }
    [NotMapped]
    public DateOnly UpdatedAt { get; set; }

    // public required Author Author { get; set; }
}