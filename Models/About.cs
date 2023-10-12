using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.Models;

public class About
{
    private static readonly string[] aboutMe =
    {
        "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
        "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
    };

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NickName? { get; set; }

    [EmailAddress]
    public string Email { get; set; }
    public string[] AboutMe { get; set; }
    public string ImageUrl { get; set; }
    public List<Education> Educations? { get; set; }
    public List<Job> Jobs? { get; set; }
}
