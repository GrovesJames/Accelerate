using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FinalProject.Migrations
{
    public partial class piturepate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 26, 10, 27, 2, 582, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/images/cognitive.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 19, 50, 26, 777, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/images/cognitive.png");
        }
    }
}
