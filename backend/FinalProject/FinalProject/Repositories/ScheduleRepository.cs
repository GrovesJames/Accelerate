using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositories
{
    public class ScheduleRepository : Repository<Schedule>, IRepository<Schedule>
    {
        private DbContext db;

        public ScheduleRepository(Context context) : base(context)
        {
            this.db = context;
        }
    }
}
