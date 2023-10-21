using System.ComponentModel.DataAnnotations;

public class UserRegisterDTO
{
    [Required]
    public required string Username { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(8)]
    [MaxLength(128)]
    public required string Password { get; set; }
}
