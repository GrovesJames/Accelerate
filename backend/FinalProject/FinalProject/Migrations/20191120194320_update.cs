using Microsoft.EntityFrameworkCore.Migrations;

using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Activities");

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Milestone = table.Column<string>(nullable: true),
                    AgeId = table.Column<string>(nullable: true),
                    SkillAssoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkillName = table.Column<string>(nullable: true),
                    DescriptionId = table.Column<string>(nullable: true),
                    AgeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillsId);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 1,
                columns: new[] { "AgeRange", "Description", "Duration", "Score" },
                values: new object[] { "3", "Play Groups", "60", 150 });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 2,
                columns: new[] { "AgeRange", "Description", "Duration", "Score" },
                values: new object[] { "3", "Read to Your Child", "20", 100 });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivitiesId", "AgeRange", "Description", "Duration", "ScheduleId", "Score" },
                values: new object[,]
                {
                    { 20, "5", "Educate: Days of the Week", "5", 1, 100 },
                    { 19, "5", "Visit the Library", "60", 1, 100 },
                    { 18, "5", "Ride A Bicycle", "20", 1, 100 },
                    { 17, "5", "Scavenger Hunt", "20", 1, 100 },
                    { 15, "5", "Petting Zoo", "60", 1, 100 },
                    { 14, "5", "Encourage your child to read to you through pictures", "25", 1, 100 },
                    { 13, "5", "Educate: Address and Phone Number", "5", 1, 100 },
                    { 12, "5", "Dance with your child", "15", 1, 100 },
                    { 16, "5", "Art Projects", "20", 1, 100 },
                    { 10, "4", "Outdoor Games (Tag, Duck Duck Goose)", "20", 1, 100 },
                    { 9, "4", "Read with your child", "20", 1, 100 },
                    { 8, "4", "Childs Choice Snack Time", "20", 1, 100 },
                    { 7, "4", "Play Make Believe", "20", 1, 100 },
                    { 6, "3", "Go to the Park or a Hiking Trail", "20", 1, 100 },
                    { 5, "3", "Play Outside", "20", 1, 100 },
                    { 4, "3", "Ascend and Descend Stairs", "20", 1, 100 },
                    { 3, "3", "Matching Games", "20", 1, 100 },
                    { 11, "4", "Dance with your child", "15", 1, 100 }
                });

            migrationBuilder.InsertData(
                table: "Milestones",
                columns: new[] { "Id", "AgeId", "Milestone", "SkillAssoc" },
                values: new object[,]
                {
                    { 37, "5", "Copies a triangle and other geometric shapes", "Cognitive Functionality" },
                    { 36, "5", "Can print some letters or numbers", "Cognitive Functionality" },
                    { 35, "5", "Can draw a person with at least 6 body parts", "Cognitive Functionality" },
                    { 34, "5", "Count 10 or more things", "Cognitive Functionality" },
                    { 29, "4", "Stars to copy some capital letters", "Cognitive Functionality" },
                    { 32, "4", "Tells you what he or she thinks is going to happen next in a book", "Cognitive Functionality" },
                    { 31, "4", "Plays board or card games", "Cognitive Functionality" },
                    { 30, "4", "Starts to copy some capital letters", "Cognitive Functionality" },
                    { 38, "5", "Knows about things used everyday, like money and food", "Cognitive Functionality" },
                    { 33, "5", "Names some colors and some numbers", "Cognitive Functionality" },
                    { 39, "3", "Climbs well", "Fine/Gross Motor Skills" },
                    { 49, "5", "Uses a fork or spoon and sometimes a table knife", "Fine/Gross Motor Skills" },
                    { 41, "3", "Pedals a Tricycle (3-Wheel Bike)", "Fine/Gross Motor Skills" },
                    { 42, "3", "Walks up and down stairs, one foot on each step", "Fine/Gross Motor Skills" },
                    { 43, "4", "Hops and stands on one foot up to 2 seconds", "Fine/Gross Motor Skills" },
                    { 44, "4", "Catches a bounced ball most of the time", "Fine/Gross Motor Skills" },
                    { 45, "4", "Pours, cuts with supervision and mashes own food", "Fine/Gross Motor Skills" },
                    { 46, "5", "Stands on one foot for 10 seconds or longer", "Fine/Gross Motor Skills" },
                    { 47, "5", "Hops, may be able to skip", "Fine/Gross Motor Skills" },
                    { 48, "5", "Can do a somersault", "Fine/Gross Motor Skills" },
                    { 28, "4", "Uses scissors", "Cognitive Functionality" },
                    { 50, "5", "Can use the toilet on his or her own", "Fine/Gross Motor Skills" },
                    { 51, "5", "Swings and climbs", "Fine/Gross Motor Skills" },
                    { 40, "3", "Runs Easily", "Fine/Gross Motor Skills" },
                    { 27, "4", "Draws a person with 2 to 4 body parts", "Cognitive Functionality" },
                    { 17, "3", "Can work toys with buttons, levers and moving parts", "Cognitive Functionality" },
                    { 25, "4", "Remembers parts of a story", "Cognitive Functionality" },
                    { 1, "3", "Follows Instructions with 2 or 3 steps", "Speech" },
                    { 2, "3", "Can name most familiar things", "Speech" },
                    { 3, "3", "Understands words like 'in,' 'on,' and 'under'", "Speech" },
                    { 4, "3", "Says first name, age, sex", "Speech" },
                    { 5, "3", "Names a Friend", "Speech" },
                    { 6, "3", "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)", "Speech" },
                    { 7, "3", "Talks well enough for strangers to understand most of the time", "Speech" },
                    { 8, "3", "Carries on a conversation using 2 to 3 sentences", "Speech" },
                    { 9, "4", "Knows some basic rules of grammar, such as correctly using 'he' and 'she'", "Speech" },
                    { 10, "4", "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'", "Speech" },
                    { 11, "4", "Tells Stories", "Speech" },
                    { 26, "4", "Understands the idea of 'same' and 'different'", "Cognitive Functionality" },
                    { 12, "4", "Can say first and last name", "Speech" },
                    { 14, "5", "Tells a simple story using full sentences", "Speech" },
                    { 15, "5", "Uses future tense; for example, 'Grandma will be here'", "Speech" },
                    { 16, "5", "Says full name and address", "Speech" },
                    { 18, "3", "Turns book pages one at a time", "Cognitive Functionality" },
                    { 19, "3", "Screws and unscrews jar lids or turns door handles", "Cognitive Functionality" },
                    { 20, "3", "Plays make-believe with dolls, animals, and people", "Cognitive Functionality" },
                    { 21, "3", "Understands what 'two' means", "Cognitive Functionality" },
                    { 22, "3", "Copies a circle with pencil or crayon", "Cognitive Functionality" },
                    { 23, "4", "Names some colors and some numbers", "Cognitive Functionality" },
                    { 24, "4", "Starts to understand time", "Cognitive Functionality" },
                    { 13, "5", "Speaks very clearly", "Speech" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillsId", "AgeId", "DescriptionId", "SkillName" },
                values: new object[,]
                {
                    { 2, "3-5", "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", "Fine/Gross Motor Skills" },
                    { 1, "3-5", "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", "Speech" },
                    { 3, "3-5", "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", "Cognitive Functionality" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 20);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Activities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 1,
                columns: new[] { "AgeRange", "Description", "Duration", "Score", "Title" },
                values: new object[] { "3-5", "Description", "10", 100, "title 1" });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivitiesId",
                keyValue: 2,
                columns: new[] { "AgeRange", "Description", "Duration", "Score", "Title" },
                values: new object[] { "3-5", "secondDescription", "33", 800, "title 2" });
        }
    }
}
