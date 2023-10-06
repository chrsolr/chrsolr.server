using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chrsolr_api.Migrations
{
    /// <inheritdoc />
    public partial class AlterSocialModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Socials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Socials");
        }
    }
}
