using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositories
{
    public class MilestoneRepository : Repository<Milestones>, IRepository<Milestones>
    {
        private DbContext db;

        public MilestoneRepository(Context context) : base(context)
        {
            this.db = context;
        }
    }
}
