public class AboutService : IAboutService
{
    private readonly DataContext _context;

    public AboutService(DataContext context)
    {
        _context = context;
    }

    public async Task<AboutDTO> GetAboutMe()
    {
        var about = new About();
        var socials = await _context.Socials
            .Select(s => new SocialDTO { Name = s.Name, Url = s.Url })
            .ToListAsync();

        return new AboutDTO
        {
            FirstName = about.FirstName,
            LastName = about.LastName,
            NickName = about.NickName,
            Email = about.Email,
            AboutMe = about.AboutMe,
            ImageUrl = about.ImageUrl,
            Socials = socials
        };
    }
}
