using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int Score { get; set; }

        public virtual int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }

        public Activities(int id, string ageRange, string description, string duration, int score, int scheduleId)
        {
            Id = id;
            AgeRange = ageRange;
            Description = description;
            Duration = duration;
            Score = score;
            ScheduleId = scheduleId;
        }
        public Activities()
        {

        }
    }
}
