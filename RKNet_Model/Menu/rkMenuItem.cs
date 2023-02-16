using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Menu
{
    public class rkMenuItem
    {
        public int rkCode { get; set; }
        public string rkName { get; set; }
        public int deliveryPrice { get; set; }
        public bool isCategory { get; set; }
        public List<rkMenuItem> rkMenuItems = new List<rkMenuItem>();
    }
}
