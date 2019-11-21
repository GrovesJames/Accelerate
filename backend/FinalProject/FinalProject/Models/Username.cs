using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Username
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public Username( int id, string name, string password)
        {
            ID = id;
            Name = name;
            Password = password;
        }
    }
}
