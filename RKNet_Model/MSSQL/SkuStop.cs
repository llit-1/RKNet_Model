using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class SkuStop
    {
        public int Id { get; set; }
        public string SkuName { get; set; }
        public string SkuRkCode { get; set; }
        public string Reason { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expiration { get; set; }
        public bool UserCancel { get; set; }
        public bool CancelMsg { get; set; }
        public bool Canceled { get; set; }
        public DateTime? UserCancelDate { get; set; }
        public string UserCancelName { get; set; }
        public int? UserCancelId { get; set; }
        public string CashStates { get; set; }
        public string State { get; set; }
        public string Finished { get; set; }

        public SkuStop()
        {
            UserCancel = false;
            CancelMsg = false;
            Canceled = false;
        }
    }
}
