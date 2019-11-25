using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class SkillFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillsActivityPlans");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "ActivityPlans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 25, 7, 51, 38, 774, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "Password", "Username" });

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgeRange", "Milestone" },
                values: new object[] { "3", "Follows Instructions with 2 or 3 steps" });

            migrationBuilder.InsertData(
                table: "Milestones",
                columns: new[] { "Id", "AgeRange", "Milestone", "SkillsId" },
                values: new object[,]
                {
                    { 27, "4", "Understands the idea of 'same' and 'different'", 2 },
                    { 28, "4", "Draws a person with 2 to 4 body parts", 2 },
                    { 29, "4", "Uses scissors", 2 },
                    { 30, "4", "Stars to copy some capital letters", 2 },
                    { 31, "4", "Plays board or card games", 2 },
                    { 32, "4", "Tells you what he or she thinks is going to happen next in a book", 2 },
                    { 33, "5", "Names some colors and some numbers", 2 },
                    { 34, "5", "Count 10 or more things", 2 },
                    { 35, "5", "Can draw a person with at least 6 body parts", 2 },
                    { 36, "5", "Can print some letters or numbers", 2 },
                    { 38, "5", "Knows about things used everyday, like money and food", 2 },
                    { 26, "4", "Remembers parts of a story", 2 },
                    { 39, "3", "Runs Easily", 3 },
                    { 40, "3", "Pedals a Tricycle (3-Wheel Bike)", 3 },
                    { 41, "3", "Walks up and down stairs, one foot on each step", 3 },
                    { 42, "4", "Hops and stands on one foot up to 2 seconds", 3 },
                    { 43, "4", "Catches a bounced ball most of the time", 3 },
                    { 44, "4", "Pours, cuts with supervision and mashes own food", 3 },
                    { 45, "5", "Stands on one foot for 10 seconds or longer", 3 },
                    { 46, "5", "Hops, may be able to skip", 3 },
                    { 47, "5", "Can do a somersault", 3 },
                    { 37, "5", "Copies a triangle and other geometric shapes", 2 },
                    { 25, "4", "Starts to understand time", 2 },
                    { 24, "4", "Names some colors and some numbers", 2 },
                    { 23, "3", "Copies a circle with pencil or crayon", 2 },
                    { 2, "3", "Can name most familiar things", 1 },
                    { 3, "3", "Says first name, age, sex", 1 },
                    { 4, "3", "Names a Friend", 1 },
                    { 5, "3", "Understands words like 'in,' 'on,' and 'under'", 1 },
                    { 6, "3", "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)", 1 },
                    { 7, "3", "Talks well enough for strangers to understand most of the time", 1 },
                    { 8, "3", "Carries on a conversation using 2 to 3 sentences", 1 },
                    { 9, "4", "Knows some basic rules of grammar, such as correctly using 'he' and 'she'", 1 },
                    { 10, "4", "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'", 1 },
                    { 11, "4", "Tells Stories", 1 },
                    { 12, "4", "Can say first and last name", 1 },
                    { 13, "5", "Speaks very clearly", 1 },
                    { 14, "5", "Tells a simple story using full sentences", 1 },
                    { 15, "5", "Uses future tense; for example, 'Grandma will be here'", 1 },
                    { 16, "5", "Says full name and address", 1 },
                    { 17, "5", "Understands words like 'in,' 'on,' and 'under'", 1 },
                    { 18, "3", "Can work toys with buttons, levers and moving parts", 2 },
                    { 19, "3", "Turns book pages one at a time", 2 },
                    { 20, "3", "Screws and unscrews jar lids or turns door handles", 2 },
                    { 21, "3", "Plays make-believe with dolls, animals, and people", 2 },
                    { 22, "3", "Understands what 'two' means", 2 },
                    { 48, "5", "Uses a fork or spoon and sometimes a table knife", 3 },
                    { 49, "5", "Can use the toilet on his or her own", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPlans_SkillId",
                table: "ActivityPlans",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityPlans_Skills_SkillId",
                table: "ActivityPlans",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityPlans_Skills_SkillId",
                table: "ActivityPlans");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropIndex(
                name: "IX_ActivityPlans_SkillId",
                table: "ActivityPlans");

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "ActivityPlans");

            migrationBuilder.CreateTable(
                name: "SkillsActivityPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityPlanId = table.Column<int>(nullable: false),
                    SkillsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsActivityPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsActivityPlans_ActivityPlans_ActivityPlanId",
                        column: x => x.ActivityPlanId,
                        principalTable: "ActivityPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillsActivityPlans_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "ActivityTime",
                value: new DateTime(2019, 11, 22, 15, 18, 3, 904, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Milestones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AgeRange", "Milestone" },
                values: new object[] { "3-6", "Test Milestone" });

            migrationBuilder.InsertData(
                table: "SkillsActivityPlans",
                columns: new[] { "Id", "ActivityPlanId", "SkillsId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_SkillsActivityPlans_ActivityPlanId",
                table: "SkillsActivityPlans",
                column: "ActivityPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsActivityPlans_SkillsId",
                table: "SkillsActivityPlans",
                column: "SkillsId");
        }
    }
}
