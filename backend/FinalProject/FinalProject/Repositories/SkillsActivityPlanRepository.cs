using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Repositories
{
    public class SkillsActivityPlanRepository : Repository<SkillsActivityPlan>, IRepository<SkillsActivityPlan>
    {
        private DbContext db;

        public SkillsActivityPlanRepository(Context context) : base(context)
        {
            this.db = context;
        }
    }

    
}
