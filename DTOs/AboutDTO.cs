using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; }
    
    [EmailAddress]
    public required string Email { get; set; }
    public required string[] AboutMe { get; set; }
    public required string ImageUrl { get; set; }
    public required List<SocialDTO> Socials { get; set; }
}
