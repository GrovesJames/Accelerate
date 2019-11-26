using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Addedskillimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Skills",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 19, 50, 26, 777, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/images/speech.jpg");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", "/images/cognitive.png", "Cognitive Functionality" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", "/images/motor.jpg", "Fine/Gross Motor Skills" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Skills");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 7, 51, 38, 774, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", "Fine/Gross Motor Skills" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", "Cognitive Functionality" });
        }
    }
}
