using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? NickName { get; set; }

    [EmailAddress]
    public required string Email { get; set; }
    public List<string> AboutMe { get; set; } = new List<string>();
    public string? ImageUrl { get; set; }
    public List<SocialDTO> Socials { get; set; } = new List<SocialDTO>();
    public List<EducationDTO> Educations { get; set; } = new List<EducationDTO>();
    public List<JobDTO> Jobs { get; set; } = new List<JobDTO>();
    public string[]? Skills { get; set; }
}
