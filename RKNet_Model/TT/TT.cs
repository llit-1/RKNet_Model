using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using RKNet_Model.Account;

namespace RKNet_Model.TT
{
    // ТОРГОВАЯ ТОЧКА
    public class TT
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Code { get; set; }
        public int Obd { get; set; }
        public Type Type { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public Organization Organization { get; set; }
        public bool Closed { get; set; }        
        public ICollection<User> Users {get; set;}        
        public ICollection<VMS.NX.NxCamera> NxCameras { get; set; }
        public ICollection<Rk7XML.CashStation> CashStations { get; set; }
        public bool YandexEda { get; set; }
        public bool DeliveryClub { get; set; }
               

        public TT()
        {
            Closed = false;
            Users = new List<User>();
            NxCameras = new List<VMS.NX.NxCamera>();
            CashStations = new List<Rk7XML.CashStation>();
            YandexEda = false;
        }
    }
}
