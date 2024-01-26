using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr.Migrations
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
                values: new object[] { new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"), new DateTime(2024, 1, 26, 17, 34, 55, 387, DateTimeKind.Utc).AddTicks(1536), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr", "E9jD8CvnezK0W6cS/7xQ8IgtuMdEn3JehL791l74WtA=", "FNfKxckaxIOae1RR/KFQ/pNmew/rZqEyx+5HNUarKZsveF2IE6kbx+EmlZkRb0jX2hndJh5+s9DqsBB02Hvohw==", new DateTime(2024, 1, 26, 17, 34, 55, 387, DateTimeKind.Utc).AddTicks(1536), "chrsolr" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "IsActive", "Markdown", "Slug", "Summary", "Title", "UpdatedAt", "UserId" },
                values: new object[] { new Guid("251e76f4-8af7-4a02-bbc0-8f35c16e9bed"), new DateTime(2024, 1, 26, 17, 34, 55, 387, DateTimeKind.Utc).AddTicks(947), "https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8", true, "![](https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8)\n# CoderCamps Bootcamp as a Student\n\nI know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.\n\n### About me\nAt age 29 I decided to get my G.E.D and go to college. I always loved computers, so choosing Information Technology was a no brainer. While working towards my degree I was introduced to an introductory C++ class. After that class all I wanted to do was programming. Since I also loved messing around with cellphones, I decided to learn more about mobile development. During the time I had a Windows Phone 7 cellphone. I started teaching myself C# and created my first application, a simple calculator.\n\nShortly after finishing my associate degree in Information Technology; I relocated to Rhode Island to pursue a Bachelors in Computer Science. The programming language taught in Rhode Island College was JAVA. Because of this and my love for mobile development, I started learning about Android Development. While at Rhode Island College I took a Software Engineer class where I built an app to find restaurants locally. I also designed an Xbox One Achievement tracker called  [Xchievements](https://www.youtube.com/watch?v=Sb2X2VhuPgY).\n\nBefore I could finish my degree I relocated once again to Houston, TX. My intentions were to find a job in the programming field. One day I saw a commercial about a programming Bootcamp advertising “Earn an average of $70k after graduation.” My first thought was “That’s BS”. But, I thought about it and decided to visit the school to get more information. My first impression was not great. I got an “it’s all bout business” vibe. After a week and much thinking and debating I decided to go.\n\n### Bootcamp time!\nSince I already had a programming background, I knew camp was not going to be as hard for me as my fellow classmates. Yes, I didn’t know anything about HTML, CSS3, JavaScript or anything that had to do with the web. But after being around and hearing so much programming you start picking up stuff quicker. I also had a month to prepare before the start of camp.\n\nAt the time, the camp was divided into three phases. Throughout all the different phases we built small applications imitating Facebook, Twitter and full CRUD (Create, Read, Update, Delete) applications. Below is a breakdown of the structure while I attended camp:\n\n#### Week 1-3\n-   HTML5\n-   CSS3\n-   JavaScript\n-   AngularJS\n\n#### Week 4-6\n-   C#\n-   ASP.NET MVC\n-   SQL Server\n-   Entity Framework\n-   Repository Pattern\n-   Web API\n-   Authentication\n\n#### Week 7-9\n-   Small group project\n-   Project inherited from previous group\n-   Individual project\n\n### Phase 1\n\nAt first, I was nervous to meet people as passionate as me about programming; as I was never surrounded by that type of environment while in college. Right away I knew everyone was there to learn. Of course, there were some personality issues between fellow students, including me; you just cannot have a bunch of people in a stressful environment without having some issues. The instructor was great. He could teach a caveman how to program, seriously. It was like he knew every form of making people learn.\n\nThe month I had to prepare really helped with HTML and CSS and the transition from an OOP language to JavaScript was seamless. In the other hand, I struggled getting my head around AngularJS. I was like “What the F*** is? Dependency Injection, Directives, Controllers and Services.” It was not a How? Question, but a Why? Question. So, I started to do my work as fast as I could and learned more about AngularJS. By the end of the first phase we got to know each other better, and everyone was getting on the same page.\n\n![](https://media.licdn.com/dms/image/C4D12AQEswgMFBdKamQ/article-inline_image-shrink_1500_2232/0/1520066214987?e=1684972800&v=beta&t=3djMkcY5F8jW39BgcZZ8hbE6yJwHJVAbU2IinxOGcLc)\n\n![](https://media.licdn.com/dms/image/C4D12AQEufCZ0uNH41A/article-inline_image-shrink_1500_2232/0/1520237234918?e=1684972800&v=beta&t=mo5y-t6YQtt-RL9QVEtbywantq5rPrR1TuaQwjPeTLA)\n\n### Phase 2\n\nThe second phase of the program was a little different. Thanks to my previous knowledge in OOP, the first week went smoothly. I took this opportunity and learned more about AngularJS and Twitter Bootstrap. I also helped my classmates understand C# and the OOP fundamentals. As we moved to ASP.NET, the pace picked up and things started getting overwhelming. I understood the classes but I would forget by the next day because we were being introduced to new logics everyday. I used my weekends to review everything we covered during the week.\n\nBy the third week most of the group had bonded. In our free time we played Jenga, went to lunch and solved programming problems together.\n\n![](https://media.licdn.com/dms/image/C4D12AQE57CN6jRM4Qg/article-inline_image-shrink_1500_2232/0/1520195237364?e=1684972800&v=beta&t=DvXIc3exMppjsUQFRV26eS2n9v9v8T6DRtkPOBemLQE)\n\n![](https://media.licdn.com/dms/image/C4D12AQHl0cUSNXi7gw/article-inline_image-shrink_1500_2232/0/1520063087886?e=1684972800&v=beta&t=CGJWeDaLZuyw5fuprqSdY9Lo3ZhqBqsJ_3KBIwnibx0)\n\n### Phase 3\n\nI feel like the third phase was where I learned the most. Not because I learned new skills, but because I got to use all the previous knowledge I learned at camp. During this phase we also got a chance to experience what to expect in the workplace. We needed to log our progress, complete tasks during given time and report all things to the staff, which pretended to be the client.\n\n![](https://media.licdn.com/dms/image/C4D12AQEGwZz6VuoIeQ/article-inline_image-shrink_1500_2232/0/1520040451164?e=1684972800&v=beta&t=PE3tTDYnDWdRoCAvtE7JRdmLhHMi0ZiKhEzCWZqFP6I)\n\n#### The Good\n\n-   Meet people with common passions\n-   Learn how others may solve a problem in a different way\n-   Learn plenty of information in a short time (This can be a bit stressful)\n-   Get help from real people and not my best friend stackoverflow.com\n-   Great environment\n\n#### The Bad\n\n-   This type of programming Bootcamp is not for everyone. It is pretty hard to get a grasp on programming in just 9 weeks with out prior knowledge. However it can be done.\n-   Do not go to Bootcamp for the wrong reasons. Remember that you are paying for this. If you are not willing to absorb everything you are taught, you wont get your moneys worth.\n-   Expanding on my previous bullet. Do not attend camp because you want a job or a great salary. To be a developer is not about knowing the syntax of a programming language. It is about taking a problem and figuring out how to solve it. You might think learning the basics will get you in the door. However if you don’t know how to brake down a problem, translate it to code and solve it efficiently, then you wont last long.\n\n### Overall\n\nCoding Bootcamp is good for people that want to learn programming or expand their knowledge, but only if they are incredibly passionate about it. Even though the boot camp staff wants you to succeed, it is all about your willingness to learn.\n\nThank you for reading.", "codercamps-bootcamp-as-a-student", "I know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.", "CoderCamps Bootcamp as a Student", new DateTime(2024, 1, 26, 17, 34, 55, 387, DateTimeKind.Utc).AddTicks(947), new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Description", "Location", "Order", "UserId" },
                values: new object[,]
                {
                    { new Guid("1709ffb9-6005-4a06-8417-461db2c65f45"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("c6e69a78-1a40-4135-a41a-c254bc6af001"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("e1493e31-1129-439a-84eb-4aa96810f425"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CompanyName", "EndDate", "StartDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("160715d3-738e-4778-a211-d4d3c14cd6d8"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("58d006c7-8778-4b5e-8de6-e6409f3c04c1"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("63f222a4-38f4-4d37-8c87-a2b8ee576fbd"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("b3cada20-c0b9-4664-af4f-dacbe6fffd57"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("b9cd0e44-61e7-4fe4-bc81-1935db7ee8fe"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("f095ac67-00cb-448a-95c2-3be323e97402"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("12ca546a-3cf3-4bee-a20d-87d3c4998896"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." },
                    { new Guid("2062b631-77a9-45f0-a573-a9e06ab3da54"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("231d8f96-da49-462e-af27-0d878ce5ce19"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "Managed and led a team of 5-7 interns on daily assignments." },
                    { new Guid("5134e2b2-3ee5-435e-92bb-3d6536d156d0"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("6084fa77-a070-4098-b9ef-06b5169722c5"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("7dd731f6-5d1c-49f6-a0f8-b5d012376733"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("a16bc34d-e9be-4b4b-bbfe-5a63e271306e"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." },
                    { new Guid("a315ae23-9919-4830-8f5a-4c40475c686b"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("b59c0b80-a38d-46e7-81e2-ec1730d15278"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("c9cb27dd-2ace-441e-8552-24e6311ca834"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("d22c4987-f431-461d-ae93-7b0b1857d524"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." },
                    { new Guid("d910d752-07f8-4de7-b69f-e6926c1734b7"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("0d71b670-67b3-42c1-a4e9-522e6e627059"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "LINQ" },
                    { new Guid("15ebf3c4-31d9-4750-bf91-ec194bd25ba7"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "AngularJs" },
                    { new Guid("18284e16-5fba-43db-8337-2dae63aded42"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "MongoDB" },
                    { new Guid("22347fbd-63f3-4c99-85b9-bbe1a77ede3f"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "ASP.NET MVC" },
                    { new Guid("2eedea36-14bb-4b32-961d-3e1c94afa46f"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "C#" },
                    { new Guid("30b526a6-4774-4800-8877-15f05693c142"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "KnockoutJs" },
                    { new Guid("4144fe68-a76f-4451-9241-0a333c13930b"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "AngularJs" },
                    { new Guid("5819b6eb-ea47-4df5-8eac-98da81eecbe6"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Docker" },
                    { new Guid("69bbaccb-3b80-46d9-83f2-9da696062c6a"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "RequireJs" },
                    { new Guid("78b3027f-3830-4ce9-a63c-8a429c3cd588"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "C#" },
                    { new Guid("7a3b2368-d47f-45a0-9e58-4f0ed140ea83"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "JavaScript" },
                    { new Guid("8237ed76-480b-44e1-9e11-1d592e540f87"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "NodeJs" },
                    { new Guid("86236162-c6de-4a76-a6a7-d3e8d8635da9"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "ReactJs" },
                    { new Guid("909f389c-17b0-4845-b366-7a1f3cc6304b"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "MS SQL" },
                    { new Guid("97febedc-2961-4bcc-93a8-a3da06e87dcd"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "MeteorJs" },
                    { new Guid("b6d26832-006b-46f3-875d-a2a694ae4b9c"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "Entity Framework" },
                    { new Guid("b7e7d819-62d7-435f-a990-32dd047e4036"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Styled Components" },
                    { new Guid("ce192b71-1981-4c78-b41a-bfd3c511184d"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "ASP.NET MVC" },
                    { new Guid("d32cb6e9-0eb5-4d37-a66e-da34e70a06ba"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "MS SQL" },
                    { new Guid("ea3ba8b2-ac75-4884-b92a-336216944b9d"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Typescript" },
                    { new Guid("f7424b34-8df4-4f0a-a850-170d9f442d54"), new Guid("8aaf15be-27b6-4be3-8b6b-5593d0a64f52"), "AJAX" },
                    { new Guid("fcc8fc19-b414-4f01-94ed-2f1dbeff0546"), new Guid("6912b443-7912-4eac-a604-950adb824e49"), "Kubernetes" },
                    { new Guid("ff28232e-2f24-4f57-8094-e6fa4ba3e5f9"), new Guid("e27bbc74-a593-4e6f-b4ab-6309d1c2502c"), "AJAX" }
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
