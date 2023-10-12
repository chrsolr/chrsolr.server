using System.ComponentModel.DataAnnotations;

namespace chrsolr_api.Models;

public class About
{
    private static readonly string[] aboutMe =
    {
        "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
        "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
    };

    public string FirstName { get; set; } = "Christian";
    public string LastName { get; set; } = "Soler";
    public string NickName { get; set; } = "Chrsolr";

    [EmailAddress]
    public string Email { get; set; } = "chr.solr@gmail.com";
    public string[] AboutMe { get; set; } = aboutMe;
    public string ImageUrl { get; set; } = "https://i.imgur.com/9X6lkc5.jpg";
}
