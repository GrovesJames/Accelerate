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
                    new Activities(1, "title 1", "3-5", "Description", "10", 100, 1),
                    new Activities(2, "title 2", "3-5", "secondDescription", "33", 800, 1)
                );
            modelBuilder.Entity<Schedule>().HasData(
                  new Schedule(1)
                );

            base.OnModelCreating(modelBuilder);
        }

    }

}

