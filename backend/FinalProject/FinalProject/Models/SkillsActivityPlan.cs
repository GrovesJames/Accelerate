using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class SkillsActivityPlan
    {
        public int SkillsId { get; set; }
        public virtual Skills Skills { get; set; }

        public int ActivityPlanId { get; set; }
        public virtual ActivityPlan ActivityPlan { get; set; }
       
    }
}
