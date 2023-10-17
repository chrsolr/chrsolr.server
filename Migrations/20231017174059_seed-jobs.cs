using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class seedjobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("108990f6-61b1-4d5f-ab5a-bef0786518d6"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("287dc96b-a6d4-4f18-8ac1-8fc51e2f5b17"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5373441f-9372-4bc8-92eb-7efdf7904e56"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("07e14d17-d03a-4912-8ee4-d557b4ce617c"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("09c2d661-5e93-4ab6-a218-5e358599ee4a"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("4a98c838-b320-4fcf-bfcb-f7069b9238d2"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("65b8f649-b457-4e36-9152-ac3c609a8341"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7f7da28d-3c90-4e9e-9ca4-11d584591286"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("c5090c39-bb6f-46dd-9300-00ef8fca9abc"));

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
                table: "Educations",
                columns: new[] { "Id", "Description", "Location", "Order", "UserId" },
                values: new object[,]
                {
                    { new Guid("74577ea6-d113-4ab6-b653-f866e4dde059"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("8174eb84-3734-4252-932e-31622c4569d3"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("e4833bb1-abeb-4596-a4e8-ebac6bf9d6bd"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CompanyName", "EndDate", "StartDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "Coder Camps", "March 2015", "September 2014", "Jr. Web Developer/Teacher Assistants", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Preventice Solutions", "June 2017", "August 2015", "Jr. Software Engineer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Innowatts Inc", "Present", "February 2018", "Full Stack Developer", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("3c479ecc-2183-4a33-908a-efa430605f4a"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5cfa6a0e-1181-4808-b104-2b3e1c528176"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("7ea5712e-dd08-41a4-9949-d51b3e7ed5dd"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("d11346ef-fa29-4736-89b8-449405af3814"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("dd6eaf18-8672-49e0-b9b8-3cebf22dddb5"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("f2922d46-95bf-4954-b1d0-e3083fbb1536"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 17, 17, 40, 58, 881, DateTimeKind.Utc).AddTicks(5650), new DateTime(2023, 10, 17, 17, 40, 58, 881, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.InsertData(
                table: "Responsibilities",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("12dcbfee-ec52-4793-a15e-4d7215ae9bcd"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Improved and modularized a highly customizable User Interface." },
                    { new Guid("27a6bc60-c2f6-427a-93db-ea519ab3a5e0"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Decouple codebase and built components make the code reusable." },
                    { new Guid("3bf2167f-a66b-4ca9-94ec-04e9695ae76e"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB." },
                    { new Guid("404ae566-b128-4648-825f-b179dfd0ccd8"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Imported and improved legacy code from older applications into an ASP.NET MVC application." },
                    { new Guid("45ba340c-c133-455d-ad4b-b5cc6f8f7546"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Deploy dockerized applications to Kubernetes via Helm charts." },
                    { new Guid("48c28a1e-702c-4915-aca1-4a80a19fa34b"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach." },
                    { new Guid("54a4066a-0c68-46cc-8bed-edcedcf2b296"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET." },
                    { new Guid("6b53850e-d621-44d6-8dfe-696827ace71d"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS." },
                    { new Guid("6dc20a39-e1c8-4346-a2b8-73f074536ecc"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "Implemented features where students can apply for a “partner’s” job through a website." },
                    { new Guid("7b52caac-d36c-460d-980a-afba409a0f43"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML." },
                    { new Guid("7d66a422-2548-4535-8115-990748df5897"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern." },
                    { new Guid("ed822a33-9ee3-4a62-9d45-b8deba3e0482"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "Managed and led a team of 5-7 interns on daily assignments." }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "JobId", "Name" },
                values: new object[,]
                {
                    { new Guid("0c6e4d46-253f-43ea-bc0d-2e856aa741be"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "MS SQL" },
                    { new Guid("1d2f1c84-739c-4e60-a4c1-6ca6662ebe4b"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "AngularJs" },
                    { new Guid("2203caf4-ad99-4957-9064-5fded8fe99da"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "ASP.NET MVC" },
                    { new Guid("34f4b55f-ec13-4ead-a2c0-af353d427474"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "AJAX" },
                    { new Guid("3f87bbb0-481c-4606-a20e-768247a4d3b8"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Docker" },
                    { new Guid("48f6a742-2d9e-4195-913b-3d4c6a05c4a1"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "JavaScript" },
                    { new Guid("54a70bb7-0489-492c-8da5-1cebcef9c113"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Typescript" },
                    { new Guid("555e9f26-4bcf-4b1c-ac57-1aee11d6a462"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "LINQ" },
                    { new Guid("58561326-2fbd-4609-9d5b-79e9e2427e7c"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Kubernetes" },
                    { new Guid("63591471-0fb6-4b01-a7bb-cf010e5dde26"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "AngularJs" },
                    { new Guid("6707929f-8a2d-4bd7-8530-f68d9281fe9e"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "MS SQL" },
                    { new Guid("6d8425ad-0463-4f5e-8d18-c7df202da24f"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "MongoDB" },
                    { new Guid("7649ccd2-558e-4511-a06d-f8fe1faad64c"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "AJAX" },
                    { new Guid("7f05804d-26a2-4526-acd9-bcb681810822"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "Entity Framework" },
                    { new Guid("85dcf5c0-d9f8-48ee-90ee-bd6b7db50a02"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "Styled Components" },
                    { new Guid("8b890482-79b3-4db9-ba2e-dfd2c7b482e0"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "ASP.NET MVC" },
                    { new Guid("a071687b-3f5f-410a-a76f-5175a1041a34"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "C#" },
                    { new Guid("ae1f90d1-70bd-45fa-9fa4-3f02f7ccb488"), new Guid("089464e4-1a7c-4bdc-ae0c-09f4f6bdc4fa"), "C#" },
                    { new Guid("ca676155-33a4-44c7-91b9-07fdaa028a33"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "ReactJs" },
                    { new Guid("d3554e88-90bc-4fef-91ac-5da9e7b367d4"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "KnockoutJs" },
                    { new Guid("dd4ac557-78e6-4976-9b4e-568ea965154e"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "MeteorJs" },
                    { new Guid("fcad6e47-4f86-46b6-b5a4-eb7b2df034ad"), new Guid("d91a8535-c3e8-4509-bb52-6cb54b9900c7"), "NodeJs" },
                    { new Guid("ffdc8057-ee78-44db-b376-a92180ccf47f"), new Guid("5d83f458-2144-4ae3-8bd3-78e71dc4c960"), "RequireJs" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_JobId",
                table: "Responsibilities",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_JobId",
                table: "Technologies",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("74577ea6-d113-4ab6-b653-f866e4dde059"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("8174eb84-3734-4252-932e-31622c4569d3"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e4833bb1-abeb-4596-a4e8-ebac6bf9d6bd"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("3c479ecc-2183-4a33-908a-efa430605f4a"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("5cfa6a0e-1181-4808-b104-2b3e1c528176"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7ea5712e-dd08-41a4-9949-d51b3e7ed5dd"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("d11346ef-fa29-4736-89b8-449405af3814"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("dd6eaf18-8672-49e0-b9b8-3cebf22dddb5"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("f2922d46-95bf-4954-b1d0-e3083fbb1536"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Description", "Location", "Order", "UserId" },
                values: new object[,]
                {
                    { new Guid("108990f6-61b1-4d5f-ab5a-bef0786518d6"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("287dc96b-a6d4-4f18-8ac1-8fc51e2f5b17"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("5373441f-9372-4bc8-92eb-7efdf7904e56"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3, new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("07e14d17-d03a-4912-8ee4-d557b4ce617c"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("09c2d661-5e93-4ab6-a218-5e358599ee4a"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("4a98c838-b320-4fcf-bfcb-f7069b9238d2"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("65b8f649-b457-4e36-9152-ac3c609a8341"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("7f7da28d-3c90-4e9e-9ca4-11d584591286"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("c5090c39-bb6f-46dd-9300-00ef8fca9abc"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 17, 16, 59, 53, 610, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 10, 17, 16, 59, 53, 610, DateTimeKind.Utc).AddTicks(8070) });
        }
    }
}
