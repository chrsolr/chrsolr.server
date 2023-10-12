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
                keyValue: new Guid("09ef3c9c-83ff-43f6-9a0e-7a4684baf311"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("275e46f0-9e5d-4f91-854d-c23e68a5b529"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("603d2561-538c-48a8-b984-a94a78dd68c6"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7d4b2150-501b-4114-aeef-b74744e318d1"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7e05000e-ac9b-44ef-8a93-8347ebee8703"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("969c2ac8-18ce-43b9-9291-5797a05438d0"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("5d9adf33-ff0c-4667-933f-5589799af962"));

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "AboutId", "Description", "Location", "Order" },
                values: new object[,]
                {
                    { new Guid("46e2a2d7-3d96-4b16-82de-0cca0c51f624"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "Associate Degree in Applied Science in Information Technology, 08/2011", "Monroe College, Bronx, NY", 3 },
                    { new Guid("62b5e7c2-bc88-49dc-b811-b362e38c51c9"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "9 Week .NET Full Stack Program, 8/2014", "Coder Camps, Pearland, TX", 1 },
                    { new Guid("e5f68253-5aa0-4d68-8814-a32962d8da63"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), "Bachelor's Degree in Computer Science, (78 Credits)", "Rhode Island College, Providence, RI", 2 }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("02add8d5-23d3-47dd-b09a-98821cdd638b"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("0797752d-78d6-44ae-bb81-7947b1de9213"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), false, "Twitch", "https://www.twitch.tv/7w3n7y" },
                    { new Guid("35c57cb8-819e-45c7-8b3b-f50116bc5219"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Github", "https://github.com/chrsolr/" },
                    { new Guid("7d69deba-fff5-4a29-9693-332d6b89eb86"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("8e4d37f6-6a80-49ee-8117-747802945223"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("c828d676-8a23-4618-91ec-d7eb318698a1"), new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"), true, "Instagram", "https://www.instagram.com/7w3n7y/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("46e2a2d7-3d96-4b16-82de-0cca0c51f624"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("62b5e7c2-bc88-49dc-b811-b362e38c51c9"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e5f68253-5aa0-4d68-8814-a32962d8da63"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("02add8d5-23d3-47dd-b09a-98821cdd638b"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("0797752d-78d6-44ae-bb81-7947b1de9213"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("35c57cb8-819e-45c7-8b3b-f50116bc5219"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7d69deba-fff5-4a29-9693-332d6b89eb86"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("8e4d37f6-6a80-49ee-8117-747802945223"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("c828d676-8a23-4618-91ec-d7eb318698a1"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("c2ff80e3-d15b-45c9-a37c-f22dbf15a456"));

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("09ef3c9c-83ff-43f6-9a0e-7a4684baf311"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("275e46f0-9e5d-4f91-854d-c23e68a5b529"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), true, "Github", "https://github.com/chrsolr/" },
                    { new Guid("603d2561-538c-48a8-b984-a94a78dd68c6"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("7d4b2150-501b-4114-aeef-b74744e318d1"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), true, "Instagram", "https://www.instagram.com/7w3n7y/" },
                    { new Guid("7e05000e-ac9b-44ef-8a93-8347ebee8703"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("969c2ac8-18ce-43b9-9291-5797a05438d0"), new Guid("5d9adf33-ff0c-4667-933f-5589799af962"), false, "Twitch", "https://www.twitch.tv/7w3n7y" }
                });
        }
    }
}
