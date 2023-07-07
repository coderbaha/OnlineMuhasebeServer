using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineMuhasebeServer.Persistance.Migrations.CompanyDb
{
    public partial class ucaf_companyid_kaldirildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "UniformChartOfAccounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "UniformChartOfAccounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
