using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class ProfileChildUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildAge",
                table: "Profile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChildName",
                table: "Profile",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 16, 17, 4, 725, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChildAge", "ChildName" },
                values: new object[] { 4, "Johnny" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildAge",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ChildName",
                table: "Profile");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 7, 51, 38, 774, DateTimeKind.Local));
        }
    }
}
