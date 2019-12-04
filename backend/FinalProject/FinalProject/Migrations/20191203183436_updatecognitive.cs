using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class updatecognitive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.");
        }
    }
}
