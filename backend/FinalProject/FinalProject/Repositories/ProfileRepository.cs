using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Repositories
{
    public class ProfileRepository : Repository<Profile>, IRepository<Profile>
    {
        private DbContext db;

        public ProfileRepository(Context context) : base(context)
        {
            this.db = context;
        }

        
    }
}
