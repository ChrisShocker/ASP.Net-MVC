using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class UpdateCustomerBirthDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var dateTime1 = new DateTime(1990, 10, 20);
            migrationBuilder.Sql("UPDATE Customers SET BirthDate = '2000/12/8' WHERE Id=1");
            migrationBuilder.Sql("UPDATE Customers SET BirthDate = '1990/8/4' WHERE Id=2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
