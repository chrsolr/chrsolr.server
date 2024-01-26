using System.ComponentModel.DataAnnotations;

namespace chrsolr.Models;

public class User
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; }
    public required string Username { get; set; }
    public required string ImageUrl { get; set; } = string.Empty;

    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    public required string Password { get; set; }

    [Required]
    public required string Salt { get; set; }

    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public List<Social> Socials { get; set; } = new List<Social>();
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Job> Jobs { get; set; } = new List<Job>();
    public List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
}
