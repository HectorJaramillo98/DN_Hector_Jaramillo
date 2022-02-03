using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.DataAccess.Migrations
{
    public partial class checkmember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "MembershipTypeId",
                table: "Members",
                newName: "MembershiptypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_MembershipTypeId",
                table: "Members",
                newName: "IX_Members_MembershiptypeId");

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MemberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checks_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_MemberId",
                table: "Checks",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipTypes_MembershiptypeId",
                table: "Members",
                column: "MembershiptypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembershipTypes_MembershiptypeId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.RenameColumn(
                name: "MembershiptypeId",
                table: "Members",
                newName: "MembershipTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_MembershiptypeId",
                table: "Members",
                newName: "IX_Members_MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembershipTypes_MembershipTypeId",
                table: "Members",
                column: "MembershipTypeId",
                principalTable: "MembershipTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
