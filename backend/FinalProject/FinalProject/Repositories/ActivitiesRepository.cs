using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Repositories
{
    public class ActivitiesRepository : Repository<Activities>, IRepository<Activities>
    {
        public ActivitiesRepository(Context context) : base(context)
        {

        }
    }
}
