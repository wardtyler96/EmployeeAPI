using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeAPI2.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    firstName = table.Column<string>(type: "text", nullable: false),
                    empId = table.Column<int>(type: "integer", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.empId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
