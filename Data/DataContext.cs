namespace chrsolr_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<Social> Socials => Set<Social>();
    public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
    public DbSet<Education> Educations => Set<Education>();
    public DbSet<Responsibility> Responsibilities => Set<Responsibility>();
    public DbSet<Job> Jobs => Set<Job>();
    public DbSet<Technology> Technologies => Set<Technology>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
            .Entity<Social>()
            .HasData(
                new Social { Url = "https://github.com/chrsolr/", Name = "Github" },
                new Social
                {
                    Url = "https://www.linkedin.com/in/christiansoler/",
                    Name = "LinkedIn"
                },
                new Social { Url = "https://codepen.io/chrsolr", Name = "Codepen" },
                new Social { Url = "https://www.instagram.com/7w3n7y/", Name = "Instagram" },
                new Social { Url = "https://www.twitch.tv/7w3n7y", Name = "Twitch" },
                new Social { Url = "https://www.youtube.com/@chrsolr", Name = "YouTube" }
            );
        string[] aboutMe =
        {
            "As a passionate and dedicated individual, I take pride in my work and approach each project with enthusiasm. Driven by challenges, I thrive in collaborative team environments and excel under pressure while juggling multiple projects.",
            "With over 6 years of experience as a Full Stack Developer, I've honed my skills in designing, developing, and implementing diverse applications using a wide array of technologies and programming languages. I am actively seeking a role in a company that values a supportive environment, where I can contribute my expertise, learn, and grow alongside fellow programming enthusiasts."
        };

        modelBuilder
            .Entity<About>()
            .HasData(
                new About
                {
                    FirstName = "Christian",
                    LastName = "Soler",
                    NickName = "Chrsolr",
                    Email = "chr.solr@gmail.com",
                    ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
                    AboutMe = aboutMe,
                }
            );
    }
}
