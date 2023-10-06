namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; }
    public required string[] AboutMe { get; set; }
    public required string ImageUrl { get; set; }
    public required List<SocialDTO> Socials { get; set; }
}
