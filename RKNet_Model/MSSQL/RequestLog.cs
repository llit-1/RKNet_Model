using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.MSSQL
{
    public class RequestLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Request { get; set; }
        public string Url { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }

        public RequestLog()
        {
            Date = DateTime.Now;
        }
    }
}
