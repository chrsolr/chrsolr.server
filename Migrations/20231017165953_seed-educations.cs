using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class seededucations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("0fd4e3c8-cdd8-4460-a52a-5e7863ec4e54"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("1750a6d6-3872-40ad-8289-1532d470cc23"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("2285852b-ff92-425e-9638-ef9e3de9b001"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("4d239178-f00a-453d-a7c6-606e38085a7d"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("a3859ed1-4b36-4786-a89f-8d98bdc7b283"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("fb7956f9-49bc-4750-ad4f-f795928dcc83"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Educations_UserId",
                table: "Educations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

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

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "IsActive", "Name", "Url", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fd4e3c8-cdd8-4460-a52a-5e7863ec4e54"), true, "Instagram", "https://www.instagram.com/7w3n7y/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("1750a6d6-3872-40ad-8289-1532d470cc23"), true, "Codepen", "https://codepen.io/chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("2285852b-ff92-425e-9638-ef9e3de9b001"), false, "YouTube", "https://www.youtube.com/@chrsolr", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("4d239178-f00a-453d-a7c6-606e38085a7d"), true, "Github", "https://github.com/chrsolr/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("a3859ed1-4b36-4786-a89f-8d98bdc7b283"), false, "Twitch", "https://www.twitch.tv/7w3n7y", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") },
                    { new Guid("fb7956f9-49bc-4750-ad4f-f795928dcc83"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/", new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 10, 17, 16, 19, 19, 551, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 10, 17, 16, 19, 19, 551, DateTimeKind.Utc).AddTicks(9470) });
        }
    }
}
