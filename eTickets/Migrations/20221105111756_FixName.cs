using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class FixName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName0",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FullName0",
                table: "Actors",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FullName0");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FullName0");
        }
    }
}
