using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class Context : DbContext
    {

        public DbSet<Activities> Activities { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Skills> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=FinalProject;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            //.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>().HasData(

                //3 y/o Activities
                new Activities(1, "3", "Play Groups", "60", 150, 1),
                new Activities(2, "3", "Read to Your Child", "20", 100, 1),
                new Activities(3, "3", "Matching Games", "20", 100, 1),
                new Activities(4, "3", "Ascend and Descend Stairs", "20", 100, 1),
                new Activities(5, "3", "Play Outside", "20", 100, 1),
                new Activities(6, "3", "Go to the Park or a Hiking Trail", "20", 100, 1),
                //4 y/o Activities
                new Activities(7, "4", "Play Make Believe", "20", 100, 1),
                new Activities(8, "4", "Childs Choice Snack Time", "20", 100, 1),
                new Activities(9, "4", "Read with your child", "20", 100, 1),
                new Activities(10, "4", "Outdoor Games (Tag, Duck Duck Goose)", "20", 100, 1),
                new Activities(11, "4", "Dance with your child", "15", 100, 1),
                //5 y/o Activities
                new Activities(12, "5", "Dance with your child", "15", 100, 1),
                new Activities(13, "5", "Educate: Address and Phone Number", "5", 100, 1),
                new Activities(14, "5", "Encourage your child to read to you through pictures", "25", 100, 1),
                new Activities(15, "5", "Petting Zoo", "60", 100, 1),
                new Activities(16, "5", "Art Projects", "20", 100, 1),
                new Activities(17, "5", "Scavenger Hunt", "20", 100, 1),
                new Activities(18, "5", "Ride A Bicycle", "20", 100, 1),
                new Activities(19, "5", "Visit the Library", "60", 100, 1),
                new Activities(20, "5", "Educate: Days of the Week", "5", 100, 1)

                );
            modelBuilder.Entity<Schedule>().HasData(
                  new Schedule(1)
                );
            modelBuilder.Entity<Skills>().HasData(
                new Skills(1, "Speech", "Children are born ready to learn a language, but they need to learn the language or languages that their family and environment use. Learning a language takes time, and children vary in how quickly they master milestones in language and speech development. Typically developing children may have trouble with some sounds, words, and sentences while they are learning. However, most children can use language easily around 5 years of age.", "3-5"),
                new Skills(2, "Fine/Gross Motor Skills", "This is the ability to use small muscles (fine motor), particularly in the hands, and large muscles (gross motor) in the body. Babies use fine motor skills to grasp objects. Toddlers and preschoolers use them to do things like hold utensils, work with objects, and draw. Babies use gross motor skills to sit up, roll over, and begin to walk. Older kids use them to do things like jump, run, and climb stairs.", "3-5"),
                new Skills(3, "Cognitive Functionality", "Children are born ready to learn, and have many skills to learn over many years. They depend on parents, family members, and other caregivers as their first teachers to develop the right skills to become independent and lead healthy and successful lives. How the brain grows is strongly affected by the child’s experiences with other people and the world. Nurturing care for the mind is critical for brain growth. Children grow and learn best in a safe environment where they are protected from neglect and from extreme or chronic stress. External with plenty of opportunities to play and explore.", "3-5")

                );

            modelBuilder.Entity<Milestones>().HasData(
                   
                    //Speech Milestones Age 3
                    new Milestones()
                    {
                        Id = 1,
                        Milestone = "Follows Instructions with 2 or 3 steps",
                        AgeId = "3",
                        SkillAssoc = "Speech"
                        
                    },
                    
                    new Milestones()
                    {
                        Id = 2,
                        Milestone = "Can name most familiar things",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 3,
                        Milestone = "Understands words like 'in,' 'on,' and 'under'",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 4,
                        Milestone = "Says first name, age, sex",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 5,
                        Milestone = "Names a Friend",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 6,
                        Milestone = "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 7,
                        Milestone = "Talks well enough for strangers to understand most of the time",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 8,
                        Milestone = "Carries on a conversation using 2 to 3 sentences",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    //Speech Milestones Age 4
                    new Milestones()
                    {
                        Id = 9,
                        Milestone = "Knows some basic rules of grammar, such as correctly using 'he' and 'she'",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 10,
                        Milestone = "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 11,
                        Milestone = "Tells Stories",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 12,
                        Milestone = "Can say first and last name",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    //Speech Milestones Age 5
                    new Milestones()
                    {
                        Id = 13,
                        Milestone = "Speaks very clearly",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 14,
                        Milestone = "Tells a simple story using full sentences",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 15,
                        Milestone = "Uses future tense; for example, 'Grandma will be here'",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 16,
                        Milestone = "Says full name and address",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    //Cognitive Functionality Milestones Age 3
                    new Milestones()
                    {
                        Id = 17,
                        Milestone = "Can work toys with buttons, levers and moving parts",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 18,
                        Milestone = "Turns book pages one at a time",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 19,
                        Milestone = "Screws and unscrews jar lids or turns door handles",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 20,
                        Milestone = "Plays make-believe with dolls, animals, and people",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 21,
                        Milestone = "Understands what 'two' means",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 22,
                        Milestone = "Copies a circle with pencil or crayon",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                   
                    //Cognitive Functionality Milestones Age 4
                    new Milestones()
                    {
                        Id = 23,
                        Milestone = "Names some colors and some numbers",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                   
                    new Milestones()
                    {
                        Id = 24,
                        Milestone = "Starts to understand time",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"
                    },
                    
                    new Milestones()
                    {
                        Id = 25,
                        Milestone = "Remembers parts of a story",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 26,
                        Milestone = "Understands the idea of 'same' and 'different'",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 27,
                        Milestone = "Draws a person with 2 to 4 body parts",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 28,
                        Milestone = "Uses scissors",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 29,
                        Milestone = "Stars to copy some capital letters",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 30,
                        Milestone = "Starts to copy some capital letters",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 31,
                        Milestone = "Plays board or card games",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 32,
                        Milestone = "Tells you what he or she thinks is going to happen next in a book",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    //Cognitive Functionality Milestones Age 5
                    new Milestones()
                    {
                        Id = 33,
                        Milestone = "Names some colors and some numbers",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 34,
                        Milestone = "Count 10 or more things",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 35,
                        Milestone = "Can draw a person with at least 6 body parts",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 36,
                        Milestone = "Can print some letters or numbers",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 37,
                        Milestone = "Copies a triangle and other geometric shapes",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 38,
                        Milestone = "Knows about things used everyday, like money and food",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 3
                    new Milestones()
                    {
                        Id = 39,
                        Milestone = "Climbs well",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    }, 
                    
                    new Milestones()
                    {
                        Id = 40,
                        Milestone = "Runs Easily",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 41,
                        Milestone = "Pedals a Tricycle (3-Wheel Bike)",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 42,
                        Milestone = "Walks up and down stairs, one foot on each step",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 4
                    new Milestones()
                    {
                        Id = 43,
                        Milestone = "Hops and stands on one foot up to 2 seconds",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 44,
                        Milestone = "Catches a bounced ball most of the time",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 45,
                        Milestone = "Pours, cuts with supervision and mashes own food",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 5
                    new Milestones()
                    {
                        Id = 46,
                        Milestone = "Stands on one foot for 10 seconds or longer",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 47,
                        Milestone = "Hops, may be able to skip",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 48,
                        Milestone = "Can do a somersault",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 49,
                        Milestone = "Uses a fork or spoon and sometimes a table knife",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 50,
                        Milestone = "Can use the toilet on his or her own",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        Id = 51,
                        Milestone = "Swings and climbs",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    //Speech Milestones Age 6
                    new Milestones()
                    {
                        Id = 52,
                        Milestone = "Start to see that some words have more than one meaning",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 53,
                        Milestone = "Speak in simple but complete sentences with five to seven words",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 54,
                        Milestone = "Follow a series of three commands in a row",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 55,
                        Milestone = "Speak with correct grammar most of the time",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 56,
                        Milestone = "Can spell their first name and can write some letters and numbers",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 57,
                        Milestone = "Read simple words",
                        AgeId = "6",
                        SkillAssoc = "Speech"

                    },

                    //Speech Milestones Age 7
                    new Milestones()
                    {
                        Id = 58,
                        Milestone = "Tend to talk a lot in situations where they are comfortable",
                        AgeId = "7",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 59,
                        Milestone = "Pronounce words correctly",
                        AgeId = "7",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 60,
                        Milestone = "Are becoming better readers",
                        AgeId = "7",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 61,
                        Milestone = "Still having some difficulty with basic spelling",
                        AgeId = "7",
                        SkillAssoc = "Speech"

                    },

                    //Speech Milestones Age 8
                    new Milestones()
                    {
                        Id = 62,
                        Milestone = "Have well-developed speech patterns and correct grammar most of the time",
                        AgeId = "8",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        Id = 63,
                        Milestone = "Become intrested in reading books aloud",
                        AgeId = "8",
                        SkillAssoc = "Speech"

                    },

                    new Milestones()
                    {
                        Id = 64,
                        Milestone = "Are still working on spelling and grammar in their written work",
                        AgeId = "8",
                        SkillAssoc = "Speech"

                    },

                    //Cognitive Milestones 6 years


                    new Milestones()
                    {
                        Id = 65,
                        Milestone = "Start to show fast growth in mental ability",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        Id = 66,
                        Milestone = "Can tell you their age",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 67,
                        Milestone = "Are learning to express themselves through words",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 68,
                        Milestone = "Can tell you their age",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 69,
                        Milestone = "Are learning to express themselves through words",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 70,
                        Milestone = "Focus on a task in school for 15 minutes or more",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 71,
                        Milestone = "Starting to grasp the concept of time",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 72,
                        Milestone = "Be able to repeat three numbers backwards",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 73,
                        Milestone = "Begin to read books that are right for his or her age",
                        AgeId = "6",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    //Cognitive Milestones 7 Years

                    new Milestones()
                    {
                        Id = 74,
                        Milestone = "Have a solid sense of time.",
                        AgeId = "7",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 75,
                        Milestone = "Begin to show preference for a learning style",
                        AgeId = "7",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 76,
                        Milestone = "Can solve simple math problems using objects",
                        AgeId = "7",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 77,
                        Milestone = "Consider issues and problems using only one factor at a time",
                        AgeId = "7",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    //Cognitive Milestones 8 Years

                    new Milestones()
                    {
                        Id = 78,
                        Milestone = "Can tell you their age",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 79,
                        Milestone = "Know how to count by 2's and 5's",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 80,
                        Milestone = "Know what day of the week it is",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 81,
                        Milestone = "Can read simple sentences",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 82,
                        Milestone = "COmplete simple addition and subtraction problems",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    new Milestones()
                    {
                        Id = 83,
                        Milestone = "Can tell the difference between right and left",
                        AgeId = "8",
                        SkillAssoc = "Cognitive Functionality"

                    },

                    //Fine and Gross Motorskills Age 6

                    new Milestones()
                    {
                        Id = 84,
                        Milestone = "Can read simple sentences",
                        AgeId = "6",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 85,
                        Milestone = "Can catch a ball",
                        AgeId = "6",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 86,
                        Milestone = "Skip with ease",
                        AgeId = "6",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 87,
                        Milestone = "Dress themselves",
                        AgeId = "6",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 88,
                        Milestone = "Major muscle activities: Running, Jumping, Skipping, and other forms of physical play",
                        AgeId = "6",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    //Fine and Gross Motor Skills Age 7

                    new Milestones()
                    {
                        Id = 89,
                        Milestone = "Increased coordination in activities such as swimming and climbing",
                        AgeId = "7",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 90,
                        Milestone = "",
                        AgeId = "7",
                        SkillAssoc = "Draw a person with 12 parts"

                    },

                    new Milestones()
                    {
                        Id = 91,
                        Milestone = "Use a pencil to write their name",
                        AgeId = "7",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 92,
                        Milestone = "Use safety scissors easily",
                        AgeId = "7",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    //Fine and Gross Motor Skills Milestones Age 8

                    new Milestones()
                    {
                        Id = 93,
                        Milestone = "Tie their shoelaces",
                        AgeId = "8",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 94,
                        Milestone = "Draw a diamond shape",
                        AgeId = "8",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 95,
                        Milestone = "Draw a person with 16 features",
                        AgeId = "8",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },

                    new Milestones()
                    {
                        Id = 96,
                        Milestone = "Become increasingly skilled in hobbies, sports and active play",
                        AgeId = "8",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    }




                );

            base.OnModelCreating(modelBuilder);
        }

    }

}

