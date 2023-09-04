
using ApplicationIot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDevices
{

    public class Device
    {
        public string Model { get; set; }
        public List<Sensor> Sensors { get; set; }
        
    }
}
