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
                    new Activities()
                    {
                        Id = 1,
                        AgeRange = "3-5",
                        Description = "1Description",
                        Duration = "10",
                        Score = 100,
                        ScheduleId = 1
                    },
                     new Activities()
                     {
                         Id = 2,
                         AgeRange = "3-5",
                         Description= "secondDescription",
                         Duration= "33",
                         Score = 800,
                         ScheduleId = 1
                     }
                );
            modelBuilder.Entity<Activities>().HasData(

                  new Schedule()
                  {
                      Id = 1
                  }
                );

            base.OnModelCreating(modelBuilder);
        }

    }

}

