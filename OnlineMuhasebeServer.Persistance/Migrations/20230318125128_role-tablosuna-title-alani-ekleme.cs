using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    public partial class roletablosunatitlealaniekleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Roles");
        }
    }
}
