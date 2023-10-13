using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.Models;

public class About
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string NickName { get; set; } = "";

    [EmailAddress]
    public required string Email { get; set; }
    public required string ImageUrl { get; set; } = "";
    public List<About> AboutMe { get; set; } = new List<About>();
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Job> Jobs { get; set; } = new List<Job>();
    public List<Social> Socials { get; set; } = new List<Social>();
}
