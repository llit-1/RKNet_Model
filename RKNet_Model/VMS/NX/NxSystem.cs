using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.VMS.NX
{
    public class NxSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public ICollection<NxCamera> NxCameras { get; set; }

        public string Type = "Nx Witness";
        public string CamerasTotal;
        public string ServersTotal;
        public bool isOnline = false;

        public NxSystem()
        {
            NxCameras = new List<NxCamera>();
        }        
    }
}
