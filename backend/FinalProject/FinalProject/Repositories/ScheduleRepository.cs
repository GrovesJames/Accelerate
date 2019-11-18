using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;

namespace FinalProject.Repositories
{
    public class ScheduleRepository : Repository<Schedule>, IRepository<Schedule>
    {
        public ScheduleRepository(Context context) : base(context)
        {

        }
    }
}
