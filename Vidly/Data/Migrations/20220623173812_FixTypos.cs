using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class FixTypos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SignupFee",
                table: "MembershipType",
                newName: "SignUpFee");

            migrationBuilder.RenameColumn(
                name: "DuationInMonths",
                table: "MembershipType",
                newName: "DurationInMonths");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SignUpFee",
                table: "MembershipType",
                newName: "SignupFee");

            migrationBuilder.RenameColumn(
                name: "DurationInMonths",
                table: "MembershipType",
                newName: "DuationInMonths");
        }
    }
}
