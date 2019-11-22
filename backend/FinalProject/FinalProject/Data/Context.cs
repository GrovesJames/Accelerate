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
        public DbSet<ActivityPlan> ActivityPlans { get; set; }
        public DbSet<Milestones> Milestones { get; set; }
        public DbSet<SkillsActivityPlan> SkillsActivityPlans { get; set; }

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

                new Activities(1, "3-6", "do stuff", 20, 200, 1, DateTime.Now)
                ////3 y/o Activities
                //new Activities(1, "3", "Play Groups", "60", 150, 1),
                //new Activities(2, "3", "Read to Your Child", "20", 100, 1),
                //new Activities(3, "3", "Matching Games", "20", 100, 1),
                //new Activities(4, "3", "Ascend and Descend Stairs", "20", 100, 1),
                //new Activities(5, "3", "Play Outside", "20", 100, 1),
                //new Activities(6, "3", "Go to the Park or a Hiking Trail", "20", 100, 1),
                ////4 y/o Activities
                //new Activities(7, "4", "Play Make Believe", "20", 100, 1),
                //new Activities(8, "4", "Childs Choice Snack Time", "20", 100, 1),
                //new Activities(9, "4", "Read with your child", "20", 100, 1),
                //new Activities(10, "4", "Outdoor Games (Tag, Duck Duck Goose)", "20", 100, 1),
                //new Activities(11, "4", "Dance with your child", "15", 100, 1),
                ////5 y/o Activities
                //new Activities(12, "5", "Dance with your child", "15", 100, 1),
                //new Activities(13, "5", "Educate: Address and Phone Number", "5", 100, 1),
                //new Activities(14, "5", "Encourage your child to read to you through pictures", "25", 100, 1),
                //new Activities(15, "5", "Petting Zoo", "60", 100, 1),
                //new Activities(16, "5", "Art Projects", "20", 100, 1),
                //new Activities(17, "5", "Scavenger Hunt", "20", 100, 1),
                //new Activities(18, "5", "Ride A Bicycle", "20", 100, 1),
                //new Activities(19, "5", "Visit the Library", "60", 100, 1),
                //new Activities(20, "5", "Educate: Days of the Week", "5", 100, 1)

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
                new Milestones(1, "Follows Instructions with 2 or 3 steps", "3-6", 1),
                new Milestones(2, "Can name most familiar things", "3-6", 1),
                new Milestones(3, "Says first name, age, sex", "3-6", 1),
                new Milestones(4, "Names a Friend", "3-6", 1),
                new Milestones(5, "Understands words like 'in,' 'on,' and 'under'", "3", 1),
                new Milestones(6, "Says words like 'I,' 'me,' 'we,' and 'you' and some plurals (cars, dogs, cats)", "3", 1),
                new Milestones(7, "Talks well enough for strangers to understand most of the time", "3", 1),
                new Milestones(8, "Carries on a conversation using 2 to 3 sentences", "3", 1),
                //Speech Milestones Age 4
                new Milestones(9, "Knows some basic rules of grammar, such as correctly using 'he' and 'she'", "4", 1),
                new Milestones(10, "Sings a song or poem from memory such as the 'itsy Bitsy Spider' or the 'Wheels on the Bus'", "4", 1),
                new Milestones(11, "Tells Stories", "4", 1),
                new Milestones(12, "Can say first and last name", "4", 1),
                //Speech Milestones Age 5
                new Milestones(13, "Speaks very clearly", "5", 1),
                new Milestones(14, "Tells a simple story using full sentences", "5", 1),
                new Milestones(15, "Uses future tense; for example, 'Grandma will be here'", "5", 1),
                new Milestones(16, "Says full name and address", "5", 1),
                new Milestones(17, "Understands words like 'in,' 'on,' and 'under'", "5", 1),
                //Cognitive Functionality Milestones Age 3
                new Milestones(18, "Can work toys with buttons, levers and moving parts", "3", 2),
                new Milestones(19, "Turns book pages one at a time", "3", 2),
                new Milestones(20, "Screws and unscrews jar lids or turns door handles", "3", 2),
                new Milestones(21, "Plays make-believe with dolls, animals, and people", "3", 2),
                new Milestones(22, "Understands what 'two' means", "3", 2),
                new Milestones(23, "Copies a circle with pencil or crayon", "3", 2),
                //Cognitive Functionality Milestones Age 4
                new Milestones(24, "Names some colors and some numbers", "4", 2),
                new Milestones(25, "Starts to understand time", "4", 2),
                new Milestones(26, "Remembers parts of a story", "4", 2),
                new Milestones(27, "Understands the idea of 'same' and 'different'", "4", 2),
                new Milestones(28, "Draws a person with 2 to 4 body parts", "4", 2),
                new Milestones(29, "Uses scissors", "4", 2),
                new Milestones(30, "Stars to copy some capital letters", "4", 2),
                new Milestones(31, "Plays board or card games", "4", 2),
                new Milestones(32, "Tells you what he or she thinks is going to happen next in a book", "4", 2),
                //Cognitive Functionality Milestones Age 5
                new Milestones(33, "Names some colors and some numbers", "5", 2),
                new Milestones(34, "Count 10 or more things", "5", 2),
                new Milestones(35, "Can draw a person with at least 6 body parts", "5", 2),
                new Milestones(36, "Can print some letters or numbers", "5", 2),
                new Milestones(37, "Copies a triangle and other geometric shapes", "5", 2),
                new Milestones(38, "Knows about things used everyday, like money and food", "5", 2),
                //Fine-Gross Motor Skill Milestones Age 3
                new Milestones(39, "Runs Easily", "3", 3),
                new Milestones(41, "Pedals a Tricycle (3-Wheel Bike)", "3", 3),
                new Milestones(42, "Walks up and down stairs, one foot on each step", "3", 3),
                //Fine-Gross Motor Skill Milestones Age 4
                new Milestones(43, "Hops and stands on one foot up to 2 seconds", "4", 3),
                new Milestones(44, "Catches a bounced ball most of the time", "4", 3),
                new Milestones(45, "Pours, cuts with supervision and mashes own food", "4", 3),
                //Fine-Gross Motor Skill Milestones Age 5
                new Milestones(46, "Stands on one foot for 10 seconds or longer", "5", 3),
                new Milestones(47, "Hops, may be able to skip", "5", 3),
                new Milestones(48, "Can do a somersault", "5", 3),
                new Milestones(49, "Uses a fork or spoon and sometimes a table knife", "5", 3),
                new Milestones(50, "Can use the toilet on his or her own", "5", 3)
            );

                
            modelBuilder.Entity<ActivityPlan>().HasData(
                new ActivityPlan(1, "Test Activity", "do the stuff", 200, 20)
            );
            modelBuilder.Entity<SkillsActivityPlan>().HasData(
                new SkillsActivityPlan(1, 1, 1)
            );

            base.OnModelCreating(modelBuilder);
        }

    }

}

