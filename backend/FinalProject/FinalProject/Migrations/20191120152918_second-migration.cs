using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Activities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 1,
                column: "Title",
                value: "title 1");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 2,
                column: "Title",
                value: "title 2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Activities");
        }
    }
}
