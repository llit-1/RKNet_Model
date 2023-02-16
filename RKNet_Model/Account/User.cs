using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RKNet_Model.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }

        public string Password { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Mail { get; set; }
        public bool AdUser { get; set; }
        public bool AllTT { get; set; }
        public bool Enabled { get; set; }
        public string LastLogin { get; set; }


        public virtual List<Role> Roles { get; set; }
        public virtual List<Group> Groups { get; set; }
        public virtual List<TT.TT> TTs {get; set;}
        public virtual Reports.UserReport Reports { get; set; }

        public User()
        {
            AdUser = false;
            Roles = new List<Role>();
            Groups = new List<Group>();
            TTs = new List<TT.TT>();
            Reports = new Reports.UserReport();
            Enabled = true;
        }        
    }
}
