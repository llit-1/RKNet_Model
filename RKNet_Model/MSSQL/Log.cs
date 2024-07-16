using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime dateTime { get; set; }
        public int userId { get; set; }
        public string userName { get; set; }
        public string Name { get; set; }
        public string userJobTitle { get; set; }
        public string IpAdress { get; set; }
        public string Description { get; set; }
        public string Json { get; set; }
        public string PortalVersion { get; set; }
        public string OS { get; set; }
        public string Browser { get; set; }
        public string SessionID { get; set; }
    }
}
