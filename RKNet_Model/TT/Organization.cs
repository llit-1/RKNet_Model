using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.TT
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string YandexLogin { get; set; }
        //public string YandexPassword { get; set; }
        //public string DeliveryClubLogin { get; set; }
        //public string DeliveryClubPassword { get; set; }
        public ICollection<TT> TTs { get; set; }

        public Organization()
        {
            TTs = new List<TT>();
        }
    }
}
