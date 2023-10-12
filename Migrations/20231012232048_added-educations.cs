using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class addededucations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_About_AboutId",
                table: "Educations");

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("30b32da4-cffb-4a7a-b889-fd6296453054"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("59b06f34-f8cf-41d4-8944-f8b39d676484"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("6be3fc14-78d2-4942-a6a4-b58a08a58ada"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("87018ea8-5c44-42e2-9bd3-9ec95d8e7fb5"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("87d3dafa-98c2-4a5e-819b-a806f64fb956"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("ae18e343-3eee-409b-9cf7-8eb7494043d8"));

            migrationBuilder.DeleteData(
                table: "About",
                keyColumn: "Id",
                keyValue: new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_About_AboutId",
                table: "Educations",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_About_AboutId",
                table: "Educations");

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

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Educations");

            migrationBuilder.AlterColumn<Guid>(
                name: "AboutId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "Email", "FirstName", "ImageUrl", "LastName", "NickName" },
                values: new object[] { new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), "chr.solr@gmail.com", "Christian", "https://i.imgur.com/9X6lkc5.jpg", "Soler", "Chrsolr" });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "AboutId", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("30b32da4-cffb-4a7a-b889-fd6296453054"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), false, "YouTube", "https://www.youtube.com/@chrsolr" },
                    { new Guid("59b06f34-f8cf-41d4-8944-f8b39d676484"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), true, "LinkedIn", "https://www.linkedin.com/in/christiansoler/" },
                    { new Guid("6be3fc14-78d2-4942-a6a4-b58a08a58ada"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), false, "Twitch", "https://www.twitch.tv/7w3n7y" },
                    { new Guid("87018ea8-5c44-42e2-9bd3-9ec95d8e7fb5"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), true, "Instagram", "https://www.instagram.com/7w3n7y/" },
                    { new Guid("87d3dafa-98c2-4a5e-819b-a806f64fb956"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), true, "Codepen", "https://codepen.io/chrsolr" },
                    { new Guid("ae18e343-3eee-409b-9cf7-8eb7494043d8"), new Guid("fa2ba8ed-adaf-40c8-8d08-820c7d27fcb6"), true, "Github", "https://github.com/chrsolr/" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_About_AboutId",
                table: "Educations",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");
        }
    }
}
