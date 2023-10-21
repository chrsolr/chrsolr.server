namespace chrsolr_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Social> Socials => Set<Social>();
    public DbSet<Education> Educations => Set<Education>();
    public DbSet<Responsibility> Responsibilities => Set<Responsibility>();
    public DbSet<Job> Jobs => Set<Job>();
    public DbSet<Technology> Technologies => Set<Technology>();
    public DbSet<BlogPost> BlogPosts => Set<BlogPost>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var userId = Guid.Parse("7ca4b089-8feb-4017-857a-b0129948a0c8");
        var innowattsId = Guid.NewGuid();
        var preventiceId = Guid.NewGuid();
        var codercampId = Guid.NewGuid();

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

        var educations = new List<Education>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Order = 1,
                Location = "Coder Camps, Pearland, TX",
                Description = "9 Week .NET Full Stack Program, 8/2014",
                UserId = userId,
            },
            new()
            {
                Id = Guid.NewGuid(),
                Order = 2,
                Location = "Rhode Island College, Providence, RI",
                Description = "Bachelor's Degree in Computer Science, (78 Credits)",
                UserId = userId,
            },
            new()
            {
                Id = Guid.NewGuid(),
                Order = 3,
                Location = "Monroe College, Bronx, NY",
                Description =
                    "Associate Degree in Applied Science in Information Technology, 08/2011",
                UserId = userId,
            }
        };

        var jobs = new List<Job>
        {
            new()
            {
                Id = innowattsId,
                CompanyName = "Innowatts Inc",
                Title = "Full Stack Developer",
                StartDate = "February 2018",
                EndDate = "Present",
                Technologies = new List<Technology>(),
                Responsibilities = new List<Responsibility>(),
                UserId = userId
            },
            new()
            {
                Id = preventiceId,
                CompanyName = "Preventice Solutions",
                Title = "Jr. Software Engineer",
                StartDate = "August 2015",
                EndDate = "June 2017",
                Technologies = new List<Technology>(),
                Responsibilities = new List<Responsibility>(),
                UserId = userId
            },
            new()
            {
                Id = codercampId,
                CompanyName = "Coder Camps",
                Title = "Jr. Web Developer/Teacher Assistants",
                StartDate = "September 2014",
                EndDate = "March 2015",
                Technologies = new List<Technology>(),
                Responsibilities = new List<Responsibility>(),
                UserId = userId
            },
        };

        var responsibilities = new List<Responsibility>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB.",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Decouple codebase and built components make the code reusable.",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach.",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Deploy dockerized applications to Kubernetes via Helm charts.",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET.",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern.",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Imported and improved legacy code from older applications into an ASP.NET MVC application.",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Improved and modularized a highly customizable User Interface.",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML.",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS.",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Implemented features where students can apply for a “partner’s” job through a website.",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Managed and led a team of 5-7 interns on daily assignments.",
                JobId = codercampId
            },
        };

        var technologies = new List<Technology>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "AngularJs",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "ReactJs",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Styled Components",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Typescript",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "NodeJs",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "MeteorJs",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "MongoDB",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Docker",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Kubernetes",
                JobId = innowattsId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "C#",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "ASP.NET MVC",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "JavaScript",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "KnockoutJs",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "RequireJs",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Entity Framework",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "AJAX",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "MS SQL",
                JobId = preventiceId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "C#",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "ASP.NET MVC",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "AngularJs",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "MS SQL",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "AJAX",
                JobId = codercampId
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "LINQ",
                JobId = codercampId
            },
        };

        var blogPosts = new List<BlogPost>
        {
            new()
            {
                Id = Guid.NewGuid(),
                Title = "CoderCamps Bootcamp as a Student",
                Summary = "I know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.",
                Markdown = "![](https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8)\n# CoderCamps Bootcamp as a Student\n\nI know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.\n\n### About me\nAt age 29 I decided to get my G.E.D and go to college. I always loved computers, so choosing Information Technology was a no brainer. While working towards my degree I was introduced to an introductory C++ class. After that class all I wanted to do was programming. Since I also loved messing around with cellphones, I decided to learn more about mobile development. During the time I had a Windows Phone 7 cellphone. I started teaching myself C# and created my first application, a simple calculator.\n\nShortly after finishing my associate degree in Information Technology; I relocated to Rhode Island to pursue a Bachelors in Computer Science. The programming language taught in Rhode Island College was JAVA. Because of this and my love for mobile development, I started learning about Android Development. While at Rhode Island College I took a Software Engineer class where I built an app to find restaurants locally. I also designed an Xbox One Achievement tracker called  [Xchievements](https://www.youtube.com/watch?v=Sb2X2VhuPgY).\n\nBefore I could finish my degree I relocated once again to Houston, TX. My intentions were to find a job in the programming field. One day I saw a commercial about a programming Bootcamp advertising “Earn an average of $70k after graduation.” My first thought was “That’s BS”. But, I thought about it and decided to visit the school to get more information. My first impression was not great. I got an “it’s all bout business” vibe. After a week and much thinking and debating I decided to go.\n\n### Bootcamp time!\nSince I already had a programming background, I knew camp was not going to be as hard for me as my fellow classmates. Yes, I didn’t know anything about HTML, CSS3, JavaScript or anything that had to do with the web. But after being around and hearing so much programming you start picking up stuff quicker. I also had a month to prepare before the start of camp.\n\nAt the time, the camp was divided into three phases. Throughout all the different phases we built small applications imitating Facebook, Twitter and full CRUD (Create, Read, Update, Delete) applications. Below is a breakdown of the structure while I attended camp:\n\n#### Week 1-3\n-   HTML5\n-   CSS3\n-   JavaScript\n-   AngularJS\n\n#### Week 4-6\n-   C#\n-   ASP.NET MVC\n-   SQL Server\n-   Entity Framework\n-   Repository Pattern\n-   Web API\n-   Authentication\n\n#### Week 7-9\n-   Small group project\n-   Project inherited from previous group\n-   Individual project\n\n### Phase 1\n\nAt first, I was nervous to meet people as passionate as me about programming; as I was never surrounded by that type of environment while in college. Right away I knew everyone was there to learn. Of course, there were some personality issues between fellow students, including me; you just cannot have a bunch of people in a stressful environment without having some issues. The instructor was great. He could teach a caveman how to program, seriously. It was like he knew every form of making people learn.\n\nThe month I had to prepare really helped with HTML and CSS and the transition from an OOP language to JavaScript was seamless. In the other hand, I struggled getting my head around AngularJS. I was like “What the F*** is? Dependency Injection, Directives, Controllers and Services.” It was not a How? Question, but a Why? Question. So, I started to do my work as fast as I could and learned more about AngularJS. By the end of the first phase we got to know each other better, and everyone was getting on the same page.\n\n![](https://media.licdn.com/dms/image/C4D12AQEswgMFBdKamQ/article-inline_image-shrink_1500_2232/0/1520066214987?e=1684972800&v=beta&t=3djMkcY5F8jW39BgcZZ8hbE6yJwHJVAbU2IinxOGcLc)\n\n![](https://media.licdn.com/dms/image/C4D12AQEufCZ0uNH41A/article-inline_image-shrink_1500_2232/0/1520237234918?e=1684972800&v=beta&t=mo5y-t6YQtt-RL9QVEtbywantq5rPrR1TuaQwjPeTLA)\n\n### Phase 2\n\nThe second phase of the program was a little different. Thanks to my previous knowledge in OOP, the first week went smoothly. I took this opportunity and learned more about AngularJS and Twitter Bootstrap. I also helped my classmates understand C# and the OOP fundamentals. As we moved to ASP.NET, the pace picked up and things started getting overwhelming. I understood the classes but I would forget by the next day because we were being introduced to new logics everyday. I used my weekends to review everything we covered during the week.\n\nBy the third week most of the group had bonded. In our free time we played Jenga, went to lunch and solved programming problems together.\n\n![](https://media.licdn.com/dms/image/C4D12AQE57CN6jRM4Qg/article-inline_image-shrink_1500_2232/0/1520195237364?e=1684972800&v=beta&t=DvXIc3exMppjsUQFRV26eS2n9v9v8T6DRtkPOBemLQE)\n\n![](https://media.licdn.com/dms/image/C4D12AQHl0cUSNXi7gw/article-inline_image-shrink_1500_2232/0/1520063087886?e=1684972800&v=beta&t=CGJWeDaLZuyw5fuprqSdY9Lo3ZhqBqsJ_3KBIwnibx0)\n\n### Phase 3\n\nI feel like the third phase was where I learned the most. Not because I learned new skills, but because I got to use all the previous knowledge I learned at camp. During this phase we also got a chance to experience what to expect in the workplace. We needed to log our progress, complete tasks during given time and report all things to the staff, which pretended to be the client.\n\n![](https://media.licdn.com/dms/image/C4D12AQEGwZz6VuoIeQ/article-inline_image-shrink_1500_2232/0/1520040451164?e=1684972800&v=beta&t=PE3tTDYnDWdRoCAvtE7JRdmLhHMi0ZiKhEzCWZqFP6I)\n\n#### The Good\n\n-   Meet people with common passions\n-   Learn how others may solve a problem in a different way\n-   Learn plenty of information in a short time (This can be a bit stressful)\n-   Get help from real people and not my best friend stackoverflow.com\n-   Great environment\n\n#### The Bad\n\n-   This type of programming Bootcamp is not for everyone. It is pretty hard to get a grasp on programming in just 9 weeks with out prior knowledge. However it can be done.\n-   Do not go to Bootcamp for the wrong reasons. Remember that you are paying for this. If you are not willing to absorb everything you are taught, you wont get your moneys worth.\n-   Expanding on my previous bullet. Do not attend camp because you want a job or a great salary. To be a developer is not about knowing the syntax of a programming language. It is about taking a problem and figuring out how to solve it. You might think learning the basics will get you in the door. However if you don’t know how to brake down a problem, translate it to code and solve it efficiently, then you wont last long.\n\n### Overall\n\nCoding Bootcamp is good for people that want to learn programming or expand their knowledge, but only if they are incredibly passionate about it. Even though the boot camp staff wants you to succeed, it is all about your willingness to learn.\n\nThank you for reading.",
                Slug = "codercamps-bootcamp-as-a-student",
                ImageUrl = "https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8",
                IsActive = true,
                UserId = userId
            },
        };


        (string Hash, string Salt) enc = AuthUtils.CreatePasswordHash("SUP3R_S3CR3T_PA55W0RD");

        var user = new User
        {
            Id = userId,
            FirstName = "Christian",
            LastName = "Soler",
            NickName = "Chrsolr",
            Email = "chr.solr@gmail.com",
            Username = "chrsolr",
            ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
            Password = enc.Hash,
            Salt = enc.Salt,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        modelBuilder.Entity<User>().HasData(user);
        modelBuilder.Entity<Social>().HasData(socials);
        modelBuilder.Entity<Education>().HasData(educations);
        modelBuilder.Entity<Responsibility>().HasData(responsibilities);
        modelBuilder.Entity<Technology>().HasData(technologies);
        modelBuilder.Entity<Job>().HasData(jobs);
        modelBuilder.Entity<BlogPost>().HasData(blogPosts);
    }
}
