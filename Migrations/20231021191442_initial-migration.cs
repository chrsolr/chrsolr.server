using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Markdown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Socials_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Responsibilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibilities_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technologies_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "ImageUrl", "LastName", "NickName", "Password", "Salt", "UpdatedAt", "Username" },
                values: new object[] { new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"), new DateTime(2023, 10, 21, 19, 14, 42, 523, DateTimeKind.Utc).AddTicks(5522), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr", "6MNWsac35QE0GMi0j1w7gEjB3K0hTwHM/WSSXq/DeJs=", "+XUXnnmbI1bFh3I8y3oBxIS3RO+wcBpWgbciESQBNcj183c7QbBN7H5GL6Mqxda+pFn/2Oyl0CitSdGa7a+DLw==", new DateTime(2023, 10, 21, 19, 14, 42, 523, DateTimeKind.Utc).AddTicks(5522), "chrsolr" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsActive", "Markdown", "Slug", "Summary", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("c8f332b4-8204-430c-b8ab-c4c740c77faf"), new DateTime(2023, 10, 21, 19, 14, 42, 523, DateTimeKind.Utc).AddTicks(4693), "https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8", true, "![](https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8)\n# CoderCamps Bootcamp as a Student\n\nI know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.\n\n### About me\nAt age 29 I decided to get my G.E.D and go to college. I always loved computers, so choosing Information Technology was a no brainer. While working towards my degree I was introduced to an introductory C++ class. After that class all I wanted to do was programming. Since I also loved messing around with cellphones, I decided to learn more about mobile development. During the time I had a Windows Phone 7 cellphone. I started teaching myself C# and created my first application, a simple calculator.\n\nShortly after finishing my associate degree in Information Technology; I relocated to Rhode Island to pursue a Bachelors in Computer Science. The programming language taught in Rhode Island College was JAVA. Because of this and my love for mobile development, I started learning about Android Development. While at Rhode Island College I took a Software Engineer class where I built an app to find restaurants locally. I also designed an Xbox One Achievement tracker called  [Xchievements](https://www.youtube.com/watch?v=Sb2X2VhuPgY).\n\nBefore I could finish my degree I relocated once again to Houston, TX. My intentions were to find a job in the programming field. One day I saw a commercial about a programming Bootcamp advertising “Earn an average of $70k after graduation.” My first thought was “That’s BS”. But, I thought about it and decided to visit the school to get more information. My first impression was not great. I got an “it’s all bout business” vibe. After a week and much thinking and debating I decided to go.\n\n### Bootcamp time!\nSince I already had a programming background, I knew camp was not going to be as hard for me as my fellow classmates. Yes, I didn’t know anything about HTML, CSS3, JavaScript or anything that had to do with the web. But after being around and hearing so much programming you start picking up stuff quicker. I also had a month to prepare before the start of camp.\n\nAt the time, the camp was divided into three phases. Throughout all the different phases we built small applications imitating Facebook, Twitter and full CRUD (Create, Read, Update, Delete) applications. Below is a breakdown of the structure while I attended camp:\n\n#### Week 1-3\n-   HTML5\n-   CSS3\n-   JavaScript\n-   AngularJS\n\n#### Week 4-6\n-   C#\n-   ASP.NET MVC\n-   SQL Server\n-   Entity Framework\n-   Repository Pattern\n-   Web API\n-   Authentication\n\n#### Week 7-9\n-   Small group project\n-   Project inherited from previous group\n-   Individual project\n\n### Phase 1\n\nAt first, I was nervous to meet people as passionate as me about programming; as I was never surrounded by that type of environment while in college. Right away I knew everyone was there to learn. Of course, there were some personality issues between fellow students, including me; you just cannot have a bunch of people in a stressful environment without having some issues. The instructor was great. He could teach a caveman how to program, seriously. It was like he knew every form of making people learn.\n\nThe month I had to prepare really helped with HTML and CSS and the transition from an OOP language to JavaScript was seamless. In the other hand, I struggled getting my head around AngularJS. I was like “What the F*** is? Dependency Injection, Directives, Controllers and Services.” It was not a How? Question, but a Why? Question. So, I started to do my work as fast as I could and learned more about AngularJS. By the end of the first phase we got to know each other better, and everyone was getting on the same page.\n\n![](https://media.licdn.com/dms/image/C4D12AQEswgMFBdKamQ/article-inline_image-shrink_1500_2232/0/1520066214987?e=1684972800&v=beta&t=3djMkcY5F8jW39BgcZZ8hbE6yJwHJVAbU2IinxOGcLc)\n\n![](https://media.licdn.com/dms/image/C4D12AQEufCZ0uNH41A/article-inline_image-shrink_1500_2232/0/1520237234918?e=1684972800&v=beta&t=mo5y-t6YQtt-RL9QVEtbywantq5rPrR1TuaQwjPeTLA)\n\n### Phase 2\n\nThe second phase of the program was a little different. Thanks to my previous knowledge in OOP, the first week went smoothly. I took this opportunity and learned more about AngularJS and Twitter Bootstrap. I also helped my classmates understand C# and the OOP fundamentals. As we moved to ASP.NET, the pace picked up and things started getting overwhelming. I understood the classes but I would forget by the next day because we were being introduced to new logics everyday. I used my weekends to review everything we covered during the week.\n\nBy the third week most of the group had bonded. In our free time we played Jenga, went to lunch and solved programming problems together.\n\n![](https://media.licdn.com/dms/image/C4D12AQE57CN6jRM4Qg/article-inline_image-shrink_1500_2232/0/1520195237364?e=1684972800&v=beta&t=DvXIc3exMppjsUQFRV26eS2n9v9v8T6DRtkPOBemLQE)\n\n![](https://media.licdn.com/dms/image/C4D12AQHl0cUSNXi7gw/article-inline_image-shrink_1500_2232/0/1520063087886?e=1684972800&v=beta&t=CGJWeDaLZuyw5fuprqSdY9Lo3ZhqBqsJ_3KBIwnibx0)\n\n### Phase 3\n\nI feel like the third phase was where I learned the most. Not because I learned new skills, but because I got to use all the previous knowledge I learned at camp. During this phase we also got a chance to experience what to expect in the workplace. We needed to log our progress, complete tasks during given time and report all things to the staff, which pretended to be the client.\n\n![](https://media.licdn.com/dms/image/C4D12AQEGwZz6VuoIeQ/article-inline_image-shrink_1500_2232/0/1520040451164?e=1684972800&v=beta&t=PE3tTDYnDWdRoCAvtE7JRdmLhHMi0ZiKhEzCWZqFP6I)\n\n#### The Good\n\n-   Meet people with common passions\n-   Learn how others may solve a problem in a different way\n-   Learn plenty of information in a short time (This can be a bit stressful)\n-   Get help from real people and not my best friend stackoverflow.com\n-   Great environment\n\n#### The Bad\n\n-   This type of programming Bootcamp is not for everyone. It is pretty hard to get a grasp on programming in just 9 weeks with out prior knowledge. However it can be done.\n-   Do not go to Bootcamp for the wrong reasons. Remember that you are paying for this. If you are not willing to absorb everything you are taught, you wont get your moneys worth.\n-   Expanding on my previous bullet. Do not attend camp because you want a job or a great salary. To be a developer is not about knowing the syntax of a programming language. It is about taking a problem and figuring out how to solve it. You might think learning the basics will get you in the door. However if you don’t know how to brake down a problem, translate it to code and solve it efficiently, then you wont last long.\n\n### Overall\n\nCoding Bootcamp is good for people that want to learn programming or expand their knowledge, but only if they are incredibly passionate about it. Even though the boot camp staff wants you to succeed, it is all about your willingness to learn.\n\nThank you for reading.", "codercamps-bootcamp-as-a-student", "I know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.", "CoderCamps Bootcamp as a Student", new DateTime(2023, 10, 21, 19, 14, 42, 523, DateTimeKind.Utc).AddTicks(4693), new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Description", "Location", "Order", "UserId" },
                values: new object[,]
                {
                    { new Guid("58be6348-bb85-48ae-819b-c0d18416b0e5"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5f1ab6b9-db87-495f-9326-f365813a1b47"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("a2d7d7a9-c640-4fed-a0e7-64dd2a5feb6c"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CompanyName", "EndDate", "StartDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("06c2c530-508e-4acf-b46a-78af76a0f317"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("48f64a83-4d8f-4dd9-9069-1289ff8274ee"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5d8362ce-fa5a-4f42-a4b9-4dcf8af6182c"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("76a5821d-c31e-4533-a7fd-2fb950ebbd1a"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("a77e6165-cc76-4505-9758-4a27881b035f"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("d4c4f98a-3261-4ab0-b316-6dc93efadb0c"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("04a84673-76dc-48f6-8c51-9a651c0802ab"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("68565b70-d48e-4646-b2bb-3b9a93fbd993"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("7faf26ae-175a-4dd7-83b0-ed38bdc565b2"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("9248ab96-8e2c-45d6-a3b5-d005569a7158"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." },
                    { new Guid("947c3d41-a484-4849-bbc7-1ea24ff008df"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("aa96e061-099c-4a11-b386-0d0b54176755"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." },
                    { new Guid("b1fa3c58-69ef-4fd1-a42f-eb4496fb2f7a"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("c13067eb-6514-4e36-9424-2e20e49a4278"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("cd02c50a-4d89-4751-bfbe-5c2195803c8b"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("d5d148fa-8701-45aa-b8bf-02212b85dba1"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." },
                    { new Guid("db7aee36-0132-4b20-9b25-07aac4c3d062"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." },
                    { new Guid("f67baec2-4960-4c88-9a97-d7f5915daa24"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "Managed and led a team of 5-7 interns on daily assignments." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("1d83ff1b-6b67-4b8e-bddc-650d167145da"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Styled Components" },
                    { new Guid("240c65a1-8bc4-445c-b9ec-4b150bcea464"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "MS SQL" },
                    { new Guid("3b9a497e-a667-4d21-9b81-9ea03b734d49"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Kubernetes" },
                    { new Guid("4e4c34e1-0341-4bb7-99cb-06fb5949f444"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "AJAX" },
                    { new Guid("67e4ed41-58b3-4686-9219-47e757d02d5a"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "NodeJs" },
                    { new Guid("6e9ee9bf-029f-4392-ad99-de0a3963fd5a"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "RequireJs" },
                    { new Guid("7522520f-11fe-4641-9ed4-6b6e0f4044e4"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "JavaScript" },
                    { new Guid("75ece98c-95d7-4dee-84bd-a6ab49bd0d06"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "AngularJs" },
                    { new Guid("82e00856-c9a7-4b28-897a-3ed2c36f2dba"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "ReactJs" },
                    { new Guid("84527d94-fb76-43a4-96d9-507f5b43588a"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "C#" },
                    { new Guid("847f1559-4840-471c-9bd0-613573631042"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "MeteorJs" },
                    { new Guid("9190b8b3-6c84-4b87-a2a3-8d8217726c69"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "ASP.NET MVC" },
                    { new Guid("979e1928-d462-43fc-a338-7b2f92cbd07e"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "C#" },
                    { new Guid("9b450e74-15ce-4378-98dc-98bab5e6cc20"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "MongoDB" },
                    { new Guid("ababeff2-e8db-4ace-9de4-f8d6b4321d1a"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "Entity Framework" },
                    { new Guid("c20d3540-29ed-47d9-ab5c-3cd570af6186"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "LINQ" },
                    { new Guid("c97a1772-d981-4229-b282-5b1ae5bd971f"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Typescript" },
                    { new Guid("cbb3cf81-b879-4b6d-a9bb-0d23769ee979"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "ASP.NET MVC" },
                    { new Guid("d2d145d6-78e7-41f1-a18d-218dde4f5a4b"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "AngularJs" },
                    { new Guid("e3cc4aa0-6010-4ea6-a5e9-9bc53fafd57a"), new Guid("6d86e0c9-e8f8-4e3e-8f1f-f0daddf38272"), "Docker" },
                    { new Guid("e6279612-7388-4679-8eaa-475865c7c6de"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "AJAX" },
                    { new Guid("f5ec7896-244c-4ab7-bd98-64eafc4c2417"), new Guid("736868cf-f2b7-42b9-805b-4c88bc101dd5"), "MS SQL" },
                    { new Guid("f7bcab27-c1c7-4f25-b476-f106236fec07"), new Guid("2192bfa2-5fa5-45ab-92bb-e59e29754d2b"), "KnockoutJs" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_UserId",
                table: "BlogPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_JobId",
                table: "Responsibilities",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Socials_UserId",
                table: "Socials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_JobId",
                table: "Technologies",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
