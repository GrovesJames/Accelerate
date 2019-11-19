using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        public virtual ICollection<Activities> Activities { get; set; }

        public Schedule(int id)
        {
            ScheduleId = id;
        }
        public Schedule()
        {

        }
    }
}
