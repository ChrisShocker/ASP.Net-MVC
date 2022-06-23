using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class PopulateAddedMovieParameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Movies SET dateAdded = '2022/6/23', releaseDate = '2002/6/23', Stock = 2 WHERE Id=1");
            migrationBuilder.Sql("UPDATE Movies SET dateAdded = '2022/6/23', releaseDate = '2000/6/23', Stock = 9 WHERE Id=2");
            migrationBuilder.Sql("UPDATE Movies SET dateAdded = '2022/6/23', releaseDate = '2012/6/23', Stock = 17 WHERE Id=3");
            migrationBuilder.Sql("UPDATE Movies SET dateAdded = '2022/6/23', releaseDate = '2022/6/23', Stock = 20 WHERE Id=4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
