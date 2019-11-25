using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }
        public virtual Profile profile { get; set; }

 

        public virtual ICollection<Activities> Activities { get; set; }

        public Schedule(int id, int profileId)
        {
            Id = id;
            ProfileId = profileId;

        }
        public Schedule()
        {

        }
    }
}
