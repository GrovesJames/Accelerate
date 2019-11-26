using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repositories
{
    public class ActivityPlanRepository : Repository<ActivityPlan>, IRepository<ActivityPlan>
    {
        private DbContext db; 

        public ActivityPlanRepository(Context context) : base(context)
        {
            this.db = context;
        }
    }
}
