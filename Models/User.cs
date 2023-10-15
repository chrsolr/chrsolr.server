using System.ComponentModel.DataAnnotations;

public class User
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    [EmailAddress]
    public required string Email { get; set; }
    public required string Username { get; set; }
    public string? ImageUrl { get; set; } = string.Empty;

    [Required]
    [MinLength(8)]
    [MaxLength(128)]
    public required string Password { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime LastLoggedInAt { get; set; }
    public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
    public List<Social> Socials { get; set; } = new List<Social>();
}
