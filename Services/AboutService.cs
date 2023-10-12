public class AboutService : IAboutService
{
    private readonly DataContext _context;

    public AboutService(DataContext context)
    {
        _context = context;
    }

    public async Task<AboutDTO> GetAboutMe()
    {
        var about = new About { Educations = new List<Education>(), Jobs = new List<Job>() };
        var socials = await _context.Socials
            .Select(s => new SocialDTO { Name = s.Name, Url = s.Url })
            .ToListAsync();

        var skills = about.Jobs.Select(j => j.Technologies.Select(t => t.Name)).ToArray();

        Console.WriteLine(skills);

        return new AboutDTO
        {
            FirstName = about.FirstName,
            LastName = about.LastName,
            NickName = about.NickName,
            Email = about.Email,
            AboutMe = about.AboutMe,
            ImageUrl = about.ImageUrl,
            Socials = socials,
            Educations = about.Educations,
            Jobs = about.Jobs,
            Skills = new string[] { }
        };
    }
}
