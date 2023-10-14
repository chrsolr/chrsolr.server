using System.ComponentModel.DataAnnotations;

public class UserLoginDTO
{
    [Required]
    [EmailAddress]
    public required string Username { get; set; }

    [Required]
    [MinLength(8)]
    [MaxLength(128)]
    public required string Password { get; set; }
}
