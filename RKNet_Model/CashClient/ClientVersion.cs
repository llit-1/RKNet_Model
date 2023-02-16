using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.CashClient
{
    public class ClientVersion
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public byte[] UpdateFile { get; set; }
        public byte[] InstallFile { get; set; }
        public bool isActual { get; set; }
    }
}
