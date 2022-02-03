using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class memberupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Members",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MembershipTypeId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Members_MembershipTypeId",
                table: "Members",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_MembershipTypeId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MembershipTypeId",
                table: "Members");
        }
    }
}
