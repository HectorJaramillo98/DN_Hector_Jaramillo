using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class checkdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Checkday",
                table: "Checks",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checkday",
                table: "Checks");
        }
    }
}
