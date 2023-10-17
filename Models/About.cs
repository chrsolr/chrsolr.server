namespace chrsolr_api.Models;

public class About
{
    public Guid Id { get; set; }
    public List<Education> Educations { get; set; } = new List<Education>();
    public List<Job> Jobs { get; set; } = new List<Job>();
}
