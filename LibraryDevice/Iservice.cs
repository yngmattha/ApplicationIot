using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDevices
{
    internal interface Iservice
    {
        public int temperatura { get; set; }
        public int umidità { get; set; }
        public int co2 { get; set; }
        double MisuraTemperatura();
        double MisuraCo2();
        double MisuraUmidità();


    }
}
