using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class OrderLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string TTName { get; set; }
        public int TTCode { get; set; }        
        public string OrderTypeName { get; set; }
        public string StatusName { get; set; }
        public int StatusCode { get; set; }
        public string Comment { get; set; }

        public OrderLog()
        {
            Date = DateTime.Now;
        }
    }
}
