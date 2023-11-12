using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marcu_Bogdan_Lab2.Migrations
{
    public partial class Borrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Book",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Book");
        }
    }
}
