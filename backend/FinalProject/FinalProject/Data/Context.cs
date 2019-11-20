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
                new Activities(19, "5", "Educate: Days of the Week", "5", 100, 1)
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
                        MilestoneId = 1,
                        Milestone = "Follows Instructions with 2 or 3 steps",
                        AgeId = "3",
                        SkillAssoc = "Speech"
                        
                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 2,
                        Milestone = "Can name most familiar things",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 3,
                        Milestone = "Understands words like 'in,' 'on,' and 'under'",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 4,
                        Milestone = "Says first name, age, sex",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 5,
                        Milestone = "Names a Friend",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 6,
                        Milestone = "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 7,
                        Milestone = "Talks well enough for strangers to understand most of the time",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 8,
                        Milestone = "Carries on a conversation using 2 to 3 sentences",
                        AgeId = "3",
                        SkillAssoc = "Speech"

                    },
                    
                    //Speech Milestones Age 4
                    new Milestones()
                    {
                        MilestoneId = 9,
                        Milestone = "Knows some basic rules of grammar, such as correctly using 'he' and 'she'",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 10,
                        Milestone = "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 11,
                        Milestone = "Tells Stories",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 12,
                        Milestone = "Can say first and last name",
                        AgeId = "4",
                        SkillAssoc = "Speech"

                    },
                    
                    //Speech Milestones Age 5
                    new Milestones()
                    {
                        MilestoneId = 13,
                        Milestone = "Speaks very clearly",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 14,
                        Milestone = "Tells a simple story using full sentences",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 15,
                        Milestone = "Uses future tense; for example, 'Grandma will be here'",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 16,
                        Milestone = "Says full name and address",
                        AgeId = "5",
                        SkillAssoc = "Speech"

                    },
                    
                    //Cognitive Functionality Milestones Age 3
                    new Milestones()
                    {
                        MilestoneId = 17,
                        Milestone = "Can work toys with buttons, levers and moving parts",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 18,
                        Milestone = "Turns book pages one at a time",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 19,
                        Milestone = "Screws and unscrews jar lids or turns door handles",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 20,
                        Milestone = "Plays make-believe with dolls, animals, and people",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 21,
                        Milestone = "Understands what 'two' means",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 22,
                        Milestone = "Copies a circle with pencil or crayon",
                        AgeId = "3",
                        SkillAssoc = "Cognitive Functionality"

                    },
                   
                    //Cognitive Functionality Milestones Age 4
                    new Milestones()
                    {
                        MilestoneId = 23,
                        Milestone = "Names some colors and some numbers",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                   
                    new Milestones()
                    {
                        MilestoneId = 24,
                        Milestone = "Starts to understand time",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"
                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 25,
                        Milestone = "Remembers parts of a story",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 26,
                        Milestone = "Understands the idea of 'same' and 'different'",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 27,
                        Milestone = "Draws a person with 2 to 4 body parts",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 28,
                        Milestone = "Uses scissors",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 29,
                        Milestone = "Stars to copy some capital letters",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 30,
                        Milestone = "Starts to copy some capital letters",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 31,
                        Milestone = "Plays board or card games",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 32,
                        Milestone = "Tells you what he or she thinks is going to happen next in a book",
                        AgeId = "4",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    //Cognitive Functionality Milestones Age 5
                    new Milestones()
                    {
                        MilestoneId = 33,
                        Milestone = "Names some colors and some numbers",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 34,
                        Milestone = "Count 10 or more things",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 35,
                        Milestone = "Can draw a person with at least 6 body parts",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 36,
                        Milestone = "Can print some letters or numbers",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 37,
                        Milestone = "Copies a triangle and other geometric shapes",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 38,
                        Milestone = "Knows about things used everyday, like money and food",
                        AgeId = "5",
                        SkillAssoc = "Cognitive Functionality"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 3
                    new Milestones()
                    {
                        MilestoneId = 39,
                        Milestone = "Climbs well",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    }, 
                    
                    new Milestones()
                    {
                        MilestoneId = 40,
                        Milestone = "Runs Easily",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 41,
                        Milestone = "Pedals a Tricycle (3-Wheel Bike)",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 42,
                        Milestone = "Walks up and down stairs, one foot on each step",
                        AgeId = "3",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 4
                    new Milestones()
                    {
                        MilestoneId = 43,
                        Milestone = "Hops and stands on one foot up to 2 seconds",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 44,
                        Milestone = "Catches a bounced ball most of the time",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 45,
                        Milestone = "Pours, cuts with supervision and mashes own food",
                        AgeId = "4",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    //Fine-Gross Motor Skill Milestones Age 5
                    new Milestones()
                    {
                        MilestoneId = 46,
                        Milestone = "Stands on one foot for 10 seconds or longer",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 47,
                        Milestone = "Hops, may be able to skip",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 48,
                        Milestone = "Can do a somersault",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 49,
                        Milestone = "Uses a fork or spoon and sometimes a table knife",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 50,
                        Milestone = "Can use the toilet on his or her own",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    },
                    
                    new Milestones()
                    {
                        MilestoneId = 51,
                        Milestone = "Swings and climbs",
                        AgeId = "5",
                        SkillAssoc = "Fine/Gross Motor Skills"

                    }

                );

            base.OnModelCreating(modelBuilder);
        }

    }

}

