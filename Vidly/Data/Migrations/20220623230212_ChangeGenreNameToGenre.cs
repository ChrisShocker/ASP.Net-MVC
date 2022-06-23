using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class ChangeGenreNameToGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genre",
                newName: "GenreName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "Genre",
                newName: "Name");
        }
    }
}
