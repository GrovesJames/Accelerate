using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositories
{
    public class LoginRepository : Repository<Login>, IRepository<Login>
    {
        private DbContext db;

        public LoginRepository(Context context) : base(context)
        {
            this.db = context;
        }

      
    }
}
