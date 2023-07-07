using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMuhasebeServer.Persistance.Migrations
{
    public partial class mainroleanduserrelationshiptableolusturma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainRoleAndUserRelationships",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MainRoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainRoleAndUserRelationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_MainRoles_MainRoleId",
                        column: x => x.MainRoleId,
                        principalTable: "MainRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainRoleAndUserRelationships_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_CompanyId",
                table: "MainRoleAndUserRelationships",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_MainRoleId",
                table: "MainRoleAndUserRelationships",
                column: "MainRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MainRoleAndUserRelationships_UserId",
                table: "MainRoleAndUserRelationships",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainRoleAndUserRelationships");
        }
    }
}
