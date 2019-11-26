using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class ProfileModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "Schedule",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 22, 15, 18, 3, 904, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "UserName" },
                values: new object[] { 1, "User1" });

            migrationBuilder.UpdateData(
                table: "Schedule",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProfileId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ProfileId",
                table: "Schedule",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Profile_ProfileId",
                table: "Schedule",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Profile_ProfileId",
                table: "Schedule");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_ProfileId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Schedule");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schedule",
                newName: "ScheduleId");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 21, 10, 15, 11, 638, DateTimeKind.Local));
        }
    }
}
