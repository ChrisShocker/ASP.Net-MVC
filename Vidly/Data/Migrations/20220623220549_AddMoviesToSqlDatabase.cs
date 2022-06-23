using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class AddMoviesToSqlDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Movies(Title, Genre) VALUES('Die Hard','Action')");
            migrationBuilder.Sql("Insert into Movies(Title, Genre) VALUES('Die Hard 2','Action')");
            migrationBuilder.Sql("Insert into Movies(Title, Genre) VALUES('Terminator','Action')");
            migrationBuilder.Sql("Insert into Movies(Title, Genre) VALUES('Halo','Action')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
