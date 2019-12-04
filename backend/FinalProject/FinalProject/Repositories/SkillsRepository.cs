using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repositories
{
        public class SkillsRepository : Repository<Skills>, IRepository<Skills>
        {
            private DbContext db;

            public SkillsRepository(Context context) : base(context)
            {
                this.db = context;
            }
            public override IEnumerable<Skills> GetAll()
            {
                return db.Set<Skills>().Include("ActivityPlans").Include("Milestones").ToList();
            }
            public override Skills GetById(int id)
            {
                return db.Set<Skills>().Where(i => i.Id == id).Include("ActivityPlans").Include("Milestones").FirstOrDefault();
            }
        }
}
