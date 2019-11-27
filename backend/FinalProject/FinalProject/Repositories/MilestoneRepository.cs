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


        public override IEnumerable<Milestones> GetByCompleted()
        {
            return db.Set<Milestones>().Where(d => d.Completed == true).Include("Skills");
        }


        public override IEnumerable<Milestones> GetByNotCompleted()
        {
            return db.Set<Milestones>().Where(d => d.Completed == false).Include("Skills");
        }
    }
}
