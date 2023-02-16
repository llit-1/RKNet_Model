using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.Audit
{
    public class Score
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Ok { get; set; }
        public int Value { get; set; }
        public string Comment { get; set; } 

        // связи
        public Item Item { get; set; }
        
        // коструктор
        public Score()
        {
            Ok = true;
            Value = 1;
        }
    }
}
