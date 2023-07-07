using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    public partial class companydekiuseridvepasswordbilgisidegistirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Companies",
                newName: "ServerUserId");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Companies",
                newName: "ServerPassword");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServerUserId",
                table: "Companies",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ServerPassword",
                table: "Companies",
                newName: "Password");
        }
    }
}
