using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKNet_Model.VMS
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PolyPoints { get; set; }
        public string Color { get; set; }
        public string Level { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public string Interval { get; set; }
        public byte[] SourceImage { get; set; }
        public string value;

        public VmsTypes VmsType { get; set; } 
        public string CameraGuid { get; set; }        


        public Zone()
        {
            Color = "0,255,0";
            Level = "80";
            StartTime = "08:00";
            StopTime = "23:00";
            Interval = "30";
        }
    }
}
