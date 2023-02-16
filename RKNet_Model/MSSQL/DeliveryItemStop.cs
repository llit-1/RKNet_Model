using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class DeliveryItemStop
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Cancelled { get; set; }
        public string UserName { get; set; }
        public int TTCode { get; set; }
        public string TTName { get; set; }
        public int ItemId { get; set; }
        public int ItemRkCode { get; set; }
        public string ItemMarketName { get; set; }

        public DeliveryItemStop()
        {
            Created = DateTime.Now;
        }
    }
}
