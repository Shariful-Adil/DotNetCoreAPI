using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreAPI.Migrations
{
    public partial class newcolumnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TechStack",
                table: "Commands",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TechStack",
                table: "Commands");
        }
    }
}
