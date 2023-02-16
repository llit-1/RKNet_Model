using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.VMS.NX
{
    public class NxCamera
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        //public NxServer NxServer { get; set; }
        public NxSystem NxSystem { get; set; }
        public TT.TT TT { get; set; }
        public CamGroup CamGroup { get; set; }
    }
}
