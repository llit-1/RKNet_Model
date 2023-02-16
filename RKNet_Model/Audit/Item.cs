using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Audit
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // связи
        public List<Item> Items { get; set; }       
        public List<Score> Scores { get; set; }

        // конструктор
        public Item()
        {
            Items = new List<Item>();
            Scores = new List<Score>();
        }
    }
}
