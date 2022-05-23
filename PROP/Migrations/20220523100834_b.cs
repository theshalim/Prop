using Microsoft.EntityFrameworkCore.Migrations;

namespace PROP.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpDesignation",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpDesignation",
                table: "Employees",
                nullable: false,
                defaultValue: "");
        }
    }
}
