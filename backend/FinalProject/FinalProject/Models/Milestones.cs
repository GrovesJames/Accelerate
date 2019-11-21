using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Milestones
    {
        public int Id { get; set; }
        public string Milestone { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }

        public virtual int SkillsId { get; set; }
        public virtual Skills Skills { get; set; }
        

        public Milestones(int id, string milestone, string ageRange, string description)
        {
            Id = id;
            Milestone = milestone;
            AgeRange = ageRange;
            Description = description;
        }
        public Milestones()
        {

        }
    }
}
