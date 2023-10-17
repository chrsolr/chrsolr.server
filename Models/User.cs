using System.ComponentModel.DataAnnotations;

public class User
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; }

    [EmailAddress]
    public required string Email { get; set; }
    public required string Username { get; set; }
    public required string ImageUrl { get; set; } = string.Empty;

    [Required]
    [MinLength(8)]
    [MaxLength(128)]
    public required string Password { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public List<Social> Socials { get; set; } = new List<Social>();
    public List<Education> Educations { get; set; } = new List<Education>();
    // public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
}
