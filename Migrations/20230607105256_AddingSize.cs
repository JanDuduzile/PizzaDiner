using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDiner.Migrations
{
    public partial class AddingSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Pizza");
        }
    }
}
