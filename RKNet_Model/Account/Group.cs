using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RKNet_Model.Account
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Group()
        {
            Roles = new List<Role>();
            Users = new List<User>();
        }
    }
}
