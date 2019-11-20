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
        public string AgeId { get; set; }
        public string SkillAssoc { get; set; }
        

        public Milestones(int id, string milestone, string ageId, string skillAssoc)
        {
            Id = id;
            Milestone = milestone;
            AgeId = ageId;
            SkillAssoc = skillAssoc;
        }
        public Milestones()
        {

        }
    }
}
