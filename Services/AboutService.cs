namespace chrsolr_api.Services;

public class AboutService : IAboutService
{
    private readonly DataContext _context;

    public AboutService(DataContext context)
    {
        _context = context;
    }

    public async Task<AboutDTO> GetAboutMe()
    {
        List<string> aboutMe = new List<string>
        {
            "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
            "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
        };

        var user = await _context.Users
            .Where(user => user.Email == "chr.solr@gmail.com")
            .Select(user => new AboutDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                NickName = user.NickName,
                Email = user.Email,
                Username = user.Username,
                ImageUrl = user.ImageUrl,
                AboutMe = aboutMe,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
                Socials = user.Socials.Where(social => social.IsActive)
                    .Select(social => new SocialDTO
                    {
                        Name = social.Name,
                        Url = social.Url
                    }).ToList(),
                Educations = user.Educations.Select(edu => new EducationDTO
                {
                    Order = edu.Order,
                    Location = edu.Location,
                    Description = edu.Description
                }).ToList()
            })
            .FirstOrDefaultAsync();


        return user;

        // var about = await _context.About
        //     .Select(
        //         v =>
        //             new AboutDTO
        //             {
        //                 FirstName = v.FirstName,
        //                 LastName = v.LastName,
        //                 NickName = v.NickName,
        //                 Email = v.Email,
        //                 ImageUrl = v.ImageUrl,
        //                 Socials = v.Socials
        //                     .Where(s => s.IsActive)
        //                     .Select(s => new SocialDTO { Name = s.Name, Url = s.Url })
        //                     .ToList(),
        //                 Educations = v.Educations
        //                     .Select(
        //                         v =>
        //                             new EducationDTO
        //                             {
        //                                 Location = v.Location,
        //                                 Description = v.Description,
        //                                 Order = v.Order
        //                             }
        //                     )
        //                     .OrderBy(v => v.Order)
        //                     .ToList(),
        //                 Jobs = v.Jobs
        //                     .Select(
        //                         v =>
        //                             new JobDTO
        //                             {
        //                                 CompanyName = v.CompanyName,
        //                                 Title = v.Title,
        //                                 StartDate = v.StartDate,
        //                                 EndDate = v.EndDate,
        //                                 Technologies = v.Technologies.Select(t => t.Name).ToArray(),
        //                                 Responsibilities = v.Responsibilities
        //                                     .Select(r => r.Name)
        //                                     .ToArray()
        //                             }
        //                     )
        //                     .ToList()
        //             }
        //     )
        //     .FirstOrDefaultAsync();

        // string[] allTechnologiesUsed = about!.Jobs
        //     .SelectMany(j => j.Technologies.Select(j => j).ToArray())
        //     .ToArray();

        // HashSet<string> uniqueSkills = new HashSet<string>(allTechnologiesUsed);
        // about.Skills = uniqueSkills.Order().ToArray();
        // about.AboutMe = aboutMe;

        // return about;
    }
}
