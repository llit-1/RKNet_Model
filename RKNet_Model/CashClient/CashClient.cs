using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.CashClient
{
    public class CashClient
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public int TTCode { get; set; }
        public string TTName { get; set; }
        public int CashId { get; set; }
        public string CashName { get; set; }
        public string CashIp { get; set; }
        public int YandexCount { get; set; }
        public int DeliveryCount { get; set; }
        public string PrinterName { get; set; }
        public string Version { get; set; }        
        public bool isOnline { get; set; }
        public DateTime LastSeen { get; set; }
        public string UpdateToVersion { get; set; }
        public string Comment { get; set; }
        
    }
}
