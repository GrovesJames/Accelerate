using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositories
{
    public class ActivitiesRepository : Repository<Activities>, IRepository<Activities>
    {
        private DbContext db;

        public ActivitiesRepository(Context context) : base(context)
        {
            this.db = context;
        }
    }
}
