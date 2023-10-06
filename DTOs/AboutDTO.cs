namespace chrsolr_api.DTOs;

public class AboutDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NickName { get; set; }
    public string[] AboutMe { get; set; }
    public string ImageUrl { get; set; }
    public required List<SocialDTO> Socials { get; set; }
}
