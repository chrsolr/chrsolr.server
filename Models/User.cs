using System.ComponentModel.DataAnnotations;

public class User
{
    public Guid Id { get; set; }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; } = string.Empty;

    [EmailAddress]
    public required string Email { get; set; }
    public required string ImageUrl { get; set; } = string.Empty;

    public required string Username { get; set; }

    [Required]
    [MinLength(8)] 
    [MaxLength(128)]
    public required string Password { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime LastLoggedInAt { get; set; }
}