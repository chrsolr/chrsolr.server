namespace chrsolr_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<About> About => Set<About>();
    public DbSet<Social> Socials => Set<Social>();
    public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
    public DbSet<Education> Educations => Set<Education>();
    public DbSet<Responsibility> Responsibilities => Set<Responsibility>();
    public DbSet<Job> Jobs => Set<Job>();
    public DbSet<Technology> Technologies => Set<Technology>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var aboutId = Guid.NewGuid();

        About about =
            new()
            {
                Id = aboutId,
                FirstName = "Christian",
                LastName = "Soler",
                NickName = "Chrsolr",
                Email = "chr.solr@gmail.com",
                ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
                // AboutMe = aboutMe,
                Jobs = new List<Job>(),
            };

        var socials = new List<Social>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://github.com/chrsolr/",
                Name = "Github",
                AboutId = aboutId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.linkedin.com/in/christiansoler/",
                Name = "LinkedIn",
                AboutId = aboutId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://codepen.io/chrsolr",
                Name = "Codepen",
                AboutId = aboutId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.instagram.com/7w3n7y/",
                Name = "Instagram",
                AboutId = aboutId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.twitch.tv/7w3n7y",
                Name = "Twitch",
                AboutId = aboutId,
                IsActive = false
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.youtube.com/@chrsolr",
                Name = "YouTube",
                AboutId = aboutId,
                IsActive = false
            }
        };

        var educations = new List<Education>{
            new () {
                Id = Guid.NewGuid(),
                Order = 1,
                Location = "Coder Camps, Pearland, TX",
                Description = "9 Week .NET Full Stack Program, 8/2014",
                AboutId = aboutId
            },
            new () {
                Id = Guid.NewGuid(),
                Order = 2,
                Location = "Rhode Island College, Providence, RI",
                Description = "Bachelor's Degree in Computer Science, (78 Credits)",
                AboutId = aboutId
            },
            new () {
                Id = Guid.NewGuid(),
                Order = 3,
                Location = "Monroe College, Bronx, NY",
                Description = "Associate Degree in Applied Science in Information Technology, 08/2011",
                AboutId = aboutId
            }
        };

        string[] aboutMe =
        {
            "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
            "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
        };

        modelBuilder.Entity<About>().HasData(about);
        modelBuilder.Entity<Social>().HasData(socials);
        modelBuilder.Entity<Education>().HasData(educations);
    }
}
