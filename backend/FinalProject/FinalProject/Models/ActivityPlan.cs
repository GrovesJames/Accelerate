using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ActivityPlan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        public int Duration { get; set; }

        public ActivityPlan( int id, string title, string description, int score, int duration)
        {
            Id = id;
            Title = title;
            Description = description;
            Score = score;
            Duration = duration;
        }
        public ActivityPlan()
        {

        }
    }
}
