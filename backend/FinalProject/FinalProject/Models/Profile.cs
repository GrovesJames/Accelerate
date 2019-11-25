using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ChildName { get; set; }
        public int ChildAge { get; set; }

        public virtual Schedule schedule { get; set; }


        public Profile(int id, string userName, string childName, int childAge)
        {
            Id = id;
            UserName = userName;
            ChildName = childName;
            ChildAge = childAge;
        }

        public Profile()
        {

        }
    }
}

    

