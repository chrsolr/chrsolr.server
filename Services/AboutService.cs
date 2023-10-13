public class AboutService : IAboutService
{
    private readonly DataContext _context;

    public AboutService(DataContext context)
    {
        _context = context;
    }

    public async Task<AboutDTO> GetAboutMe()
    {
        string[] aboutMe =
        {
            "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
            "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
        };

        var about = await _context.About
            .Select(
                v =>
                    new AboutDTO
                    {
                        FirstName = v.FirstName,
                        LastName = v.LastName,
                        NickName = v.NickName,
                        Email = v.Email,
                        ImageUrl = v.ImageUrl,
                        Socials = v.Socials
                            .Where(s => s.IsActive)
                            .Select(s => new SocialDTO { Name = s.Name, Url = s.Url })
                            .ToList(),
                        Educations = v.Educations
                            .Select(
                                v =>
                                    new EducationDTO
                                    {
                                        Location = v.Location,
                                        Description = v.Description,
                                        Order = v.Order
                                    }
                            )
                            .OrderBy(v => v.Order)
                            .ToList(),
                        Jobs = v.Jobs
                            .Select(
                                v =>
                                    new JobDTO
                                    {
                                        CompanyName = v.CompanyName,
                                        Title = v.Title,
                                        StartDate = v.StartDate,
                                        EndDate = v.EndDate,
                                        Technologies = v.Technologies.Select(t => t.Name).ToArray(),
                                        Responsibilities = v.Responsibilities
                                            .Select(r => r.Name)
                                            .ToArray()
                                    }
                            )
                            .ToList()
                    }
            )
            .FirstOrDefaultAsync();

        string[] allTechnologiesUsed = about!.Jobs
            .SelectMany(j => j.Technologies.Select(j => j).ToArray())
            .ToArray();

        HashSet<string> uniqueSkills = new HashSet<string>(allTechnologiesUsed);
        about.Skills = uniqueSkills.Order().ToArray();

        return about;
    }
}
