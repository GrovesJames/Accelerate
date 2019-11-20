using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Skills
    {
        public int SkillsId { get; set; }
        public string SkillName { get; set; }
        public string DescriptionId { get; set; }
        public string AgeId { get; set; }

        public Skills(int id, string skillName, string descriptionId, string ageId)
        {
            SkillsId = id;
            SkillName = skillName;
            DescriptionId = descriptionId;
            AgeId = ageId;
        }
        public Skills()
        {

        }
    }
}
