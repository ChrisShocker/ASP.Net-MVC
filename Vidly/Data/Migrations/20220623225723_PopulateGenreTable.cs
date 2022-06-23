using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class PopulateGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Genre(Name) VALUES('Action')");
            migrationBuilder.Sql("Insert into Genre(Name) VALUES('Comedy')");
            migrationBuilder.Sql("Insert into Genre(Name) VALUES('Romance')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
