namespace chrsolr_api.Models;

public class About
{
    public Guid Id { get; set; }
    public List<About> AboutMe { get; set; } = new List<About>();
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Job> Jobs { get; set; } = new List<Job>();
    public List<Social> Socials { get; set; } = new List<Social>();
}
