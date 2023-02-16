using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RKNet_Model.Account
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

        public Role()
        {
            Users = new List<User>();
            Groups = new List<Group>();
        }
    }
}
