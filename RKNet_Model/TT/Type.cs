using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.TT
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TT> TTs { get; set; }

        public Type()
        {
            TTs = new List<TT>();
        }
    }
}
