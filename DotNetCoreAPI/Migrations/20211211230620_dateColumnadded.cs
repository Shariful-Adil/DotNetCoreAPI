using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreAPI.Migrations
{
    public partial class dateColumnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Commands",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Commands");
        }
    }
}
