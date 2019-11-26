using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AgeRange { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Milestones> Milestones { get; set; }
        public virtual ICollection<ActivityPlan> ActivityPlans { get; set; }


        public Skills(int id, string name, string description, string ageRange, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            AgeRange = ageRange;
            Image = image;
        }
        public Skills()
        {

        }
    }
}
