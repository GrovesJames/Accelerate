using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class changeActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ActivitiesId",
                table: "Activities",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 21, 10, 15, 11, 638, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Activities",
                newName: "ActivitiesId");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 21, 10, 12, 46, 557, DateTimeKind.Local));
        }
    }
}
