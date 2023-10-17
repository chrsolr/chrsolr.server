namespace chrsolr_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Social> Socials => Set<Social>();
    // public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
    // public DbSet<About> About => Set<About>();
    // public DbSet<Education> Educations => Set<Education>();
    // public DbSet<Responsibility> Responsibilities => Set<Responsibility>();
    // public DbSet<Job> Jobs => Set<Job>();
    // public DbSet<Technology> Technologies => Set<Technology>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var userId = Guid.Parse("7ca4b089-8feb-4017-857a-b0129948a0c8"); // Guid.NewGuid();
        // var aboutId = Guid.NewGuid();
        // var innowattsId = Guid.NewGuid();
        // var preventiceId = Guid.NewGuid();
        // var codercampId = Guid.NewGuid();


        // var about = new About()
        // {
        //     Id = aboutId,
        //     FirstName = "Christian",
        //     LastName = "Soler",
        //     NickName = "Chrsolr",
        //     Email = "chr.solr@gmail.com",
        //     ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
        // };

        var socials = new List<Social>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://github.com/chrsolr/",
                Name = "Github",
                UserId = userId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.linkedin.com/in/christiansoler/",
                Name = "LinkedIn",
                UserId = userId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://codepen.io/chrsolr",
                Name = "Codepen",
                UserId = userId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.instagram.com/7w3n7y/",
                Name = "Instagram",
                UserId = userId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.twitch.tv/7w3n7y",
                Name = "Twitch",
                UserId = userId,
                IsActive = false
            },
            new()
            {
                Id = Guid.NewGuid(),
                Url = "https://www.youtube.com/@chrsolr",
                Name = "YouTube",
                UserId = userId,
                IsActive = false
            }
        };

        // var educations = new List<Education>
        // {
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Order = 1,
        //         Location = "Coder Camps, Pearland, TX",
        //         Description = "9 Week .NET Full Stack Program, 8/2014",
        //         AboutId = aboutId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Order = 2,
        //         Location = "Rhode Island College, Providence, RI",
        //         Description = "Bachelor's Degree in Computer Science, (78 Credits)",
        //         AboutId = aboutId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Order = 3,
        //         Location = "Monroe College, Bronx, NY",
        //         Description =
        //             "Associate Degree in Applied Science in Information Technology, 08/2011",
        //         AboutId = aboutId
        //     }
        // };

        // var jobs = new List<Job>
        // {
        //     new()
        //     {
        //         Id = innowattsId,
        //         CompanyName = "Innowatts Inc",
        //         Title = "Full Stack Developer",
        //         StartDate = "February 2018",
        //         EndDate = "Present",
        //         Technologies = new List<Technology>(),
        //         Responsibilities = new List<Responsibility>(),
        //         AboutId = aboutId
        //     },
        //     new()
        //     {
        //         Id = preventiceId,
        //         CompanyName = "Preventice Solutions",
        //         Title = "Jr. Software Engineer",
        //         StartDate = "August 2015",
        //         EndDate = "June 2017",
        //         Technologies = new List<Technology>(),
        //         Responsibilities = new List<Responsibility>(),
        //         AboutId = aboutId
        //     },
        //     new()
        //     {
        //         Id = codercampId,
        //         CompanyName = "Coder Camps",
        //         Title = "Jr. Web Developer/Teacher Assistants",
        //         StartDate = "September 2014",
        //         EndDate = "March 2015",
        //         Technologies = new List<Technology>(),
        //         Responsibilities = new List<Responsibility>(),
        //         AboutId = aboutId
        //     },
        // };

        // var responsibilities = new List<Responsibility>
        // {
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB.",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Decouple codebase and built components make the code reusable.",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach.",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Deploy dockerized applications to Kubernetes via Helm charts.",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET.",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern.",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Imported and improved legacy code from older applications into an ASP.NET MVC application.",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Improved and modularized a highly customizable User Interface.",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML.",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS.",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name =
        //             "Implemented features where students can apply for a “partner’s” job through a website.",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Managed and led a team of 5-7 interns on daily assignments.",
        //         JobId = codercampId
        //     },
        // };

        // var technologies = new List<Technology>
        // {
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "AngularJs",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "ReactJs",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Styled Components",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Typescript",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "NodeJs",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "MeteorJs",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "MongoDB",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Docker",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Kubernetes",
        //         JobId = innowattsId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "C#",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "ASP.NET MVC",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "JavaScript",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "KnockoutJs",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "RequireJs",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "Entity Framework",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "AJAX",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "MS SQL",
        //         JobId = preventiceId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "C#",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "ASP.NET MVC",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "AngularJs",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "MS SQL",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "AJAX",
        //         JobId = codercampId
        //     },
        //     new()
        //     {
        //         Id = Guid.NewGuid(),
        //         Name = "LINQ",
        //         JobId = codercampId
        //     },
        // };
        //
        var user = new User
        {
            Id = userId,
            FirstName = "Christian",
            LastName = "Soler",
            NickName = "Chrsolr",
            Email = "chr.solr@gmail.com",
            Username = "chrsolr",
            ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
            Password = "",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            Socials = socials
        };

        modelBuilder.Entity<User>().HasData(user);
        modelBuilder.Entity<Social>().HasData(socials);
        // modelBuilder.Entity<About>().HasData(about);
        // modelBuilder.Entity<Education>().HasData(educations);
        // modelBuilder.Entity<Responsibility>().HasData(responsibilities);
        // modelBuilder.Entity<Technology>().HasData(technologies);
        // modelBuilder.Entity<Job>().HasData(jobs);
    }
}
