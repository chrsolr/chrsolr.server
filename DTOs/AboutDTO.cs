using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? NickName { get; set; }
    
    [EmailAddress]
    public required string Email { get; set; }
    public string[]? AboutMe { get; set; }
    public string? ImageUrl { get; set; }
    public List<SocialDTO> Socials { get; set; } = new List<SocialDTO>();
    public List<EducationDTO> Educations { get; set; } = new List<EducationDTO>();
    public List<Job>? Jobs { get; set; }
    public string[]? Skills { get; set; }
}
