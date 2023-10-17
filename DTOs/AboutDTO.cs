namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; }
    public required string Email { get; set; }
    public required string Username { get; set; }
    public required string ImageUrl { get; set; } = string.Empty;
    public List<string> AboutMe { get; set; } = new List<string>();
    public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public required DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public List<SocialDTO> Socials { get; set; } = new List<SocialDTO>();





    // public List<EducationDTO> Educations { get; set; } = new List<EducationDTO>();
    // public List<JobDTO> Jobs { get; set; } = new List<JobDTO>();
    // public string[]? Skills { get; set; }
}
