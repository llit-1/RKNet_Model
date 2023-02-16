using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RKNet_Model.Reports
{
    public class UserReport
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string ProfitFree { get; set; }
        public string ProfitPro { get; set; }
        
        public virtual Account.User User {get; set;}

        public UserReport()
        {
            ProfitFree = "";
            ProfitPro = "";
        }
    }
}
