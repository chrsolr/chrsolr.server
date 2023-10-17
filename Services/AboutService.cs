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
                }).ToList(),
                Jobs = user.Jobs.Select(job => new JobDTO
                {
                    CompanyName = job.CompanyName,
                    Title = job.Title,
                    StartDate = job.StartDate,
                    EndDate = job.EndDate,
                    Technologies = job.Technologies.Select(tech => tech.Name).ToArray(),
                    Responsibilities = job.Responsibilities
                        .Select(responsibility => responsibility.Name)
                        .ToArray()
                }).ToList()
            })
            .FirstOrDefaultAsync();

        string[] allTechnologiesUsed = user!.Jobs
            .SelectMany(j => j.Technologies.Select(j => j).ToArray())
            .ToArray();

        user.Skills = new HashSet<string>(allTechnologiesUsed).Order().ToArray(); ;

        return user;
    }
}
