using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                values: new object[] { new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"), new DateTime(2024, 5, 18, 3, 46, 9, 59, DateTimeKind.Utc).AddTicks(8794), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr", "YM0ZMPmg1VlIGlNdE/biDWslZH43iJ8zxhetxhG5quw=", "MjG4K36XBDoDfdpx0tKfy9hD/EgunD/Nm7CWyi1hwJIcxhI8wUU/tGs7bVnteoNyXYNIHVrmYTC4X2A4DQRh2Q==", new DateTime(2024, 5, 18, 3, 46, 9, 59, DateTimeKind.Utc).AddTicks(8794), "chrsolr" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsActive", "Markdown", "Slug", "Summary", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("adac6469-01d5-4c23-b483-27802b1e00b9"), new DateTime(2024, 5, 18, 3, 46, 9, 59, DateTimeKind.Utc).AddTicks(8060), "https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8", true, "![](https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8)\n# CoderCamps Bootcamp as a Student\n\nI know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.\n\n### About me\nAt age 29 I decided to get my G.E.D and go to college. I always loved computers, so choosing Information Technology was a no brainer. While working towards my degree I was introduced to an introductory C++ class. After that class all I wanted to do was programming. Since I also loved messing around with cellphones, I decided to learn more about mobile development. During the time I had a Windows Phone 7 cellphone. I started teaching myself C# and created my first application, a simple calculator.\n\nShortly after finishing my associate degree in Information Technology; I relocated to Rhode Island to pursue a Bachelors in Computer Science. The programming language taught in Rhode Island College was JAVA. Because of this and my love for mobile development, I started learning about Android Development. While at Rhode Island College I took a Software Engineer class where I built an app to find restaurants locally. I also designed an Xbox One Achievement tracker called  [Xchievements](https://www.youtube.com/watch?v=Sb2X2VhuPgY).\n\nBefore I could finish my degree I relocated once again to Houston, TX. My intentions were to find a job in the programming field. One day I saw a commercial about a programming Bootcamp advertising “Earn an average of $70k after graduation.” My first thought was “That’s BS”. But, I thought about it and decided to visit the school to get more information. My first impression was not great. I got an “it’s all bout business” vibe. After a week and much thinking and debating I decided to go.\n\n### Bootcamp time!\nSince I already had a programming background, I knew camp was not going to be as hard for me as my fellow classmates. Yes, I didn’t know anything about HTML, CSS3, JavaScript or anything that had to do with the web. But after being around and hearing so much programming you start picking up stuff quicker. I also had a month to prepare before the start of camp.\n\nAt the time, the camp was divided into three phases. Throughout all the different phases we built small applications imitating Facebook, Twitter and full CRUD (Create, Read, Update, Delete) applications. Below is a breakdown of the structure while I attended camp:\n\n#### Week 1-3\n-   HTML5\n-   CSS3\n-   JavaScript\n-   AngularJS\n\n#### Week 4-6\n-   C#\n-   ASP.NET MVC\n-   SQL Server\n-   Entity Framework\n-   Repository Pattern\n-   Web API\n-   Authentication\n\n#### Week 7-9\n-   Small group project\n-   Project inherited from previous group\n-   Individual project\n\n### Phase 1\n\nAt first, I was nervous to meet people as passionate as me about programming; as I was never surrounded by that type of environment while in college. Right away I knew everyone was there to learn. Of course, there were some personality issues between fellow students, including me; you just cannot have a bunch of people in a stressful environment without having some issues. The instructor was great. He could teach a caveman how to program, seriously. It was like he knew every form of making people learn.\n\nThe month I had to prepare really helped with HTML and CSS and the transition from an OOP language to JavaScript was seamless. In the other hand, I struggled getting my head around AngularJS. I was like “What the F*** is? Dependency Injection, Directives, Controllers and Services.” It was not a How? Question, but a Why? Question. So, I started to do my work as fast as I could and learned more about AngularJS. By the end of the first phase we got to know each other better, and everyone was getting on the same page.\n\n![](https://media.licdn.com/dms/image/C4D12AQEswgMFBdKamQ/article-inline_image-shrink_1500_2232/0/1520066214987?e=1684972800&v=beta&t=3djMkcY5F8jW39BgcZZ8hbE6yJwHJVAbU2IinxOGcLc)\n\n![](https://media.licdn.com/dms/image/C4D12AQEufCZ0uNH41A/article-inline_image-shrink_1500_2232/0/1520237234918?e=1684972800&v=beta&t=mo5y-t6YQtt-RL9QVEtbywantq5rPrR1TuaQwjPeTLA)\n\n### Phase 2\n\nThe second phase of the program was a little different. Thanks to my previous knowledge in OOP, the first week went smoothly. I took this opportunity and learned more about AngularJS and Twitter Bootstrap. I also helped my classmates understand C# and the OOP fundamentals. As we moved to ASP.NET, the pace picked up and things started getting overwhelming. I understood the classes but I would forget by the next day because we were being introduced to new logics everyday. I used my weekends to review everything we covered during the week.\n\nBy the third week most of the group had bonded. In our free time we played Jenga, went to lunch and solved programming problems together.\n\n![](https://media.licdn.com/dms/image/C4D12AQE57CN6jRM4Qg/article-inline_image-shrink_1500_2232/0/1520195237364?e=1684972800&v=beta&t=DvXIc3exMppjsUQFRV26eS2n9v9v8T6DRtkPOBemLQE)\n\n![](https://media.licdn.com/dms/image/C4D12AQHl0cUSNXi7gw/article-inline_image-shrink_1500_2232/0/1520063087886?e=1684972800&v=beta&t=CGJWeDaLZuyw5fuprqSdY9Lo3ZhqBqsJ_3KBIwnibx0)\n\n### Phase 3\n\nI feel like the third phase was where I learned the most. Not because I learned new skills, but because I got to use all the previous knowledge I learned at camp. During this phase we also got a chance to experience what to expect in the workplace. We needed to log our progress, complete tasks during given time and report all things to the staff, which pretended to be the client.\n\n![](https://media.licdn.com/dms/image/C4D12AQEGwZz6VuoIeQ/article-inline_image-shrink_1500_2232/0/1520040451164?e=1684972800&v=beta&t=PE3tTDYnDWdRoCAvtE7JRdmLhHMi0ZiKhEzCWZqFP6I)\n\n#### The Good\n\n-   Meet people with common passions\n-   Learn how others may solve a problem in a different way\n-   Learn plenty of information in a short time (This can be a bit stressful)\n-   Get help from real people and not my best friend stackoverflow.com\n-   Great environment\n\n#### The Bad\n\n-   This type of programming Bootcamp is not for everyone. It is pretty hard to get a grasp on programming in just 9 weeks with out prior knowledge. However it can be done.\n-   Do not go to Bootcamp for the wrong reasons. Remember that you are paying for this. If you are not willing to absorb everything you are taught, you wont get your moneys worth.\n-   Expanding on my previous bullet. Do not attend camp because you want a job or a great salary. To be a developer is not about knowing the syntax of a programming language. It is about taking a problem and figuring out how to solve it. You might think learning the basics will get you in the door. However if you don’t know how to brake down a problem, translate it to code and solve it efficiently, then you wont last long.\n\n### Overall\n\nCoding Bootcamp is good for people that want to learn programming or expand their knowledge, but only if they are incredibly passionate about it. Even though the boot camp staff wants you to succeed, it is all about your willingness to learn.\n\nThank you for reading.", "codercamps-bootcamp-as-a-student", "I know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.", "CoderCamps Bootcamp as a Student", new DateTime(2024, 5, 18, 3, 46, 9, 59, DateTimeKind.Utc).AddTicks(8060), new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Description", "Location", "Order", "UserId" },
                values: new object[,]
                {
                    { new Guid("0be5420d-36c3-4c23-9482-69972c73893a"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("d99e4ac8-d057-4594-a0ea-145e9fd19df5"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("f0430416-5e0a-4525-ba0b-4a0f4778dfd3"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CompanyName", "EndDate", "StartDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("2bbdbb5e-0cf7-4ac6-886a-c4dee51a394d"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("304ae82e-d1df-4084-8266-d84165c0fa07"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("3a6a8251-6dfc-469d-a2b0-a8c7651c483f"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5c73442c-a1fc-4454-bdcd-36c4c143f945"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("629556dc-ac8f-43c9-a23d-6e9339d8a8cf"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("69f68d72-2438-4e0c-b612-5c34b25c8d7a"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("08986a1f-e6f7-4c7a-a46f-dd3289aed1db"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("20339553-3fa7-493d-a60a-7a50eec9394f"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("37ba0bc6-2ebf-4dd6-b221-e3ddf2e98fda"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("6387dc55-f728-442c-9f4a-40711eacc91a"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." },
                    { new Guid("853edf42-54c1-4eb1-8246-a006c1308d5b"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("8699114c-ba5f-44ce-9918-615807dd3329"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." },
                    { new Guid("8dafee8e-d9f1-4e2b-ab4a-6976703b8ea1"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." },
                    { new Guid("9c23e28f-5988-4014-824d-8bbfd1b4e37f"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("9cda03bb-91c8-4e43-ac0f-b8afb0f1ae39"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "Managed and led a team of 5-7 interns on daily assignments." },
                    { new Guid("afb5cd8b-e325-4446-aae4-93e21de391a2"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("ea55671b-c5cf-4b7f-8824-219258c26992"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("fb3772de-f969-4cdb-aabf-075ae33ccae0"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("1479f531-0f52-455c-8ea4-36e0c577faea"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "MeteorJs" },
                    { new Guid("1da1e541-176f-40a9-9d68-cedbbb0cb83f"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Kubernetes" },
                    { new Guid("21b1d579-7246-4c69-a2f1-9386156f9f9f"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Styled Components" },
                    { new Guid("3bfb0b3a-f3b4-448d-bac3-8fe1cd248b1b"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "MongoDB" },
                    { new Guid("494cabe6-ea7f-49e9-854f-b9e48de5f2e1"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "ASP.NET MVC" },
                    { new Guid("4d566f56-03b6-4716-98c0-ffaba4fff9fd"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "ReactJs" },
                    { new Guid("5a0de964-bbe8-4b5e-8f3e-8d98e4d4b485"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "JavaScript" },
                    { new Guid("6ce46649-e283-4afa-b956-c0580dd8c709"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "MS SQL" },
                    { new Guid("716e0796-dac2-4f19-9a0f-b485577d1964"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "AngularJs" },
                    { new Guid("7b41aa47-0990-469b-a788-772e6602be3a"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Typescript" },
                    { new Guid("89531e03-1a4f-4a5e-80af-2e5cb96bae72"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "KnockoutJs" },
                    { new Guid("8e81c108-afdc-49f5-bd51-68189ef3445f"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "LINQ" },
                    { new Guid("9d4e4ff6-741f-47e4-8313-04b3c0e8ca89"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "AJAX" },
                    { new Guid("ae975f86-7342-48b9-9921-7ec12c5a22ca"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "MS SQL" },
                    { new Guid("b49ac3b7-880c-4bdc-ac74-08030bdfab6a"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "NodeJs" },
                    { new Guid("c9b27ca4-d7ed-4695-8cc9-aec5ff61e893"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "AngularJs" },
                    { new Guid("cae5a231-9a15-42a4-9472-ebc7fc0368b9"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "C#" },
                    { new Guid("cf3aa678-673c-4a04-b4c8-1bc984befd54"), new Guid("fd82e605-db9a-4bce-9a48-1d4413a61d1e"), "Docker" },
                    { new Guid("d255c912-f4ba-43c7-86cc-49a24ca3193a"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "RequireJs" },
                    { new Guid("d85ab30a-bad3-4ef2-a02a-03b2d60ee83c"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "Entity Framework" },
                    { new Guid("db0092c8-8e3d-41f9-ba62-5916ce8fce9c"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "AJAX" },
                    { new Guid("df304561-1df8-4f1c-85bc-c913ec24848d"), new Guid("c57ef7d0-0383-46f8-8a8d-a96b0c6b2530"), "C#" },
                    { new Guid("f3ea4552-7c2f-4b7b-a3b8-89a4f7b7e44a"), new Guid("d19db1d5-abd8-4162-ab4b-857ed5b02699"), "ASP.NET MVC" }
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
