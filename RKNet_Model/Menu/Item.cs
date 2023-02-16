using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Menu
{
    public class Item
    {
        // поля
        public int Id { get; set; }
        public string rkName { get; set; }
        public int rkCode { get; set; }
        public int rkDeliveryPrice { get; set; }
        public string marketName { get; set; }        
        public string Description { get; set; }
        public int Measure { get; set; }
        public byte[] Image { get; set; }
        public string ImageHash { get; set; }
        public bool Enabled { get; set; }

        // связи        
        public Category ParentCategory { get; set; }
        public MeasureUnit MeasureUnit { get; set; }

        public Item()
        {
            ParentCategory = new Category();
            MeasureUnit = new MeasureUnit();
            Enabled = true;
        }
    }
}
