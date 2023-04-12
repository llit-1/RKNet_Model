using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Rk7XML
{
    public class CashStation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Midserver { get; set; }
        public string Ip { get; set; }
        public TT.TT TT { get; set; }
    }
}
