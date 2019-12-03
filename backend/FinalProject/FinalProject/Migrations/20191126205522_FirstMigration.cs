using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    ChildName = table.Column<string>(nullable: true),
                    ChildAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Profile_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    SkillsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityPlans_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Milestone = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    SkillsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestones_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    AgeRange = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ActivityTime = table.Column<DateTime>(nullable: false),
                    ScheduleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "Password", "Username" });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "ChildAge", "ChildName", "UserName" },
                values: new object[] { 1, 4, "Johnny", "User1" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "AgeRange", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "3-5", "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", "/images/speech.jpg", "Speech" },
                    { 2, "3-5", "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", "/images/cognitive.jpg", "Cognitive Functionality" },
                    { 3, "3-5", "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", "/images/motor.jpg", "Fine/Gross Motor Skills" }
                });

            migrationBuilder.InsertData(
                table: "ActivityPlans",
                columns: new[] { "Id", "AgeRange", "Description", "Duration", "Score", "SkillsId", "Title" },
                values: new object[,]
                {
                    { 5, "3", "Outdoor Time", 55, 45, 3, "Play Outside" },
                    { 8, "4", "Snacks", 5, 15, 2, "Childs Choice Snack Time" },
                    { 7, "4", "Make Believe", 35, 25, 2, "Play Make Believe" },
                    { 3, "3", "Games", 20, 15, 2, "Matching Games" },
                    { 1, "3", "Play Groups", 45, 60, 3, "Play Groups" },
                    { 4, "3", "Stairs", 20, 5, 3, "Ascend and Descend Stairs" },
                    { 16, "5", "Scavenger Hunt", 45, 30, 2, "Scavenger Hunt" },
                    { 6, "3", "Trail Time", 100, 60, 3, "Go to the Park or a Hiking Trail" },
                    { 10, "4", "Games", 100, 30, 3, "Outdoor Games (Tag, Duck Duck Goose)" },
                    { 11, "4", "Dance", 100, 20, 3, "Dance with your child" },
                    { 17, "5", "Bike Ride", 75, 35, 3, "Ride A Bicycle" },
                    { 19, "5", "Educate", 60, 20, 2, "Educate: Days of the Week" },
                    { 14, "5", "Zoo", 90, 90, 2, "Petting Zoo" },
                    { 15, "5", "Art Projects", 65, 45, 2, "Art Projects" },
                    { 18, "5", "Library", 100, 60, 1, "Visit the Library" },
                    { 13, "5", "Child Reads", 90, 25, 1, "Encourage your child to read to you through pictures" },
                    { 12, "5", "Educate Address", 100, 20, 1, "Educate: Address and Phone Number" },
                    { 9, "4", "Reading", 50, 20, 1, "Read with your child" },
                    { 2, "3", "Reading", 50, 20, 1, "Read to Your Child" }
                });

            migrationBuilder.InsertData(
                table: "Milestones",
                columns: new[] { "Id", "AgeRange", "Milestone", "SkillsId" },
                values: new object[,]
                {
                    { 36, "5", "Can print some letters or numbers", 2 },
                    { 35, "5", "Can draw a person with at least 6 body parts", 2 },
                    { 34, "5", "Count 10 or more things", 2 },
                    { 33, "5", "Names some colors and some numbers", 2 },
                    { 32, "4", "Tells you what he or she thinks is going to happen next in a book", 2 },
                    { 31, "4", "Plays board or card games", 2 },
                    { 37, "5", "Copies a triangle and other geometric shapes", 2 },
                    { 38, "5", "Knows about things used everyday, like money and food", 2 },
                    { 22, "3", "Understands what 'two' means", 2 },
                    { 39, "3", "Runs Easily", 3 },
                    { 40, "3", "Pedals a Tricycle (3-Wheel Bike)", 3 },
                    { 41, "3", "Walks up and down stairs, one foot on each step", 3 },
                    { 42, "4", "Hops and stands on one foot up to 2 seconds", 3 },
                    { 43, "4", "Catches a bounced ball most of the time", 3 },
                    { 44, "4", "Pours, cuts with supervision and mashes own food", 3 },
                    { 45, "5", "Stands on one foot for 10 seconds or longer", 3 },
                    { 46, "5", "Hops, may be able to skip", 3 },
                    { 47, "5", "Can do a somersault", 3 },
                    { 30, "4", "Stars to copy some capital letters", 2 },
                    { 29, "4", "Uses scissors", 2 },
                    { 49, "5", "Can use the toilet on his or her own", 3 },
                    { 27, "4", "Understands the idea of 'same' and 'different'", 2 },
                    { 1, "3", "Follows Instructions with 2 or 3 steps", 1 },
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
                    { 18, "3", "Can work toys with buttons, levers and moving parts", 2 },
                    { 19, "3", "Turns book pages one at a time", 2 },
                    { 20, "3", "Screws and unscrews jar lids or turns door handles", 2 },
                    { 21, "3", "Plays make-believe with dolls, animals, and people", 2 },
                    { 48, "5", "Uses a fork or spoon and sometimes a table knife", 3 },
                    { 23, "3", "Copies a circle with pencil or crayon", 2 },
                    { 24, "4", "Names some colors and some numbers", 2 },
                    { 25, "4", "Starts to understand time", 2 },
                    { 26, "4", "Remembers parts of a story", 2 },
                    { 28, "4", "Draws a person with 2 to 4 body parts", 2 }
                });

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "ProfileId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ScheduleId",
                table: "Activities",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPlans_SkillsId",
                table: "ActivityPlans",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestones_SkillsId",
                table: "Milestones",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ProfileId",
                table: "Schedule",
                column: "ProfileId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "ActivityPlans");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
