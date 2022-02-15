using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerExam.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "Customer_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Customer_Id",
                table: "Customers",
                newName: "Id");
        }
    }
}
