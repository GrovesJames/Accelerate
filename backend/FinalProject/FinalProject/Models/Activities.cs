using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Activities
    {
        public int Id { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int Score { get; set; }
        public DateTime ActivityTime { get; set; }

        public int ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }

        public Activities(int id, string ageRange, string description, int duration, int score, int scheduleId, DateTime activityTime)
        {
            Id = id;
            AgeRange = ageRange;
            Description = description;
            Duration = duration;
            Score = score;
            ScheduleId = scheduleId;
            ActivityTime = activityTime;
        }
        public Activities()
        {

        }
    }
}
