using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.Models;

public class About
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? NickName { get; set; }

    [EmailAddress]
    public required string Email { get; set; }
    public string? ImageUrl { get; set; }
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Job>? Jobs { get; set; }
    public List<Social> Socials { get; set; } = new List<Social>();

    // public string[]? AboutMe { get; set; }
}
