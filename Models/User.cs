using System.ComponentModel.DataAnnotations;

public class User
{
    public Guid Id { get; set; }

    [EmailAddress]
    public required string Username { get; set; }

    [Required]
    [MinLength(8)]
    [MaxLength(128)]
    public required string Password { get; set; }
    public required string FullName { get; set; }
    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; }
    public required DateTime LastLoggedInAt { get; set; }
}
