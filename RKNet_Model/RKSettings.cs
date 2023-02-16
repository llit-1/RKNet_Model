using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model
{
    public class RKSettings
    {
        public int Id { get; set; }
        public string RefServerIp { get; set; }
        public string RefServerPort { get; set; }
        public string CashPort { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DeliveryPriceType { get; set; }

    }
}
