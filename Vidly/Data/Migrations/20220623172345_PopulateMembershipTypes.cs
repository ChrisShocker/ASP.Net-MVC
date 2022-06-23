using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    public partial class PopulateMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Fist Membership type:
            migrationBuilder.Sql("Insert into MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(1,0,0,0)");
            //Second Membership type:
            migrationBuilder.Sql("Insert into MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(2,30,1,10)");
            //Thrid Membership type:
            migrationBuilder.Sql("Insert into MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(3,90,3,15)");
            //Fourth Membership type:
            migrationBuilder.Sql("Insert into MembershipType(Id, SignUpFee, DurationInMonths, DiscountRate) VALUES(4,300,12,20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
