using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.VMS
{
    public class CamGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NX.NxCamera> NxCameras { get; set; }

        public CamGroup()
        {
            NxCameras = new List<NX.NxCamera>();
        }
    }
}
