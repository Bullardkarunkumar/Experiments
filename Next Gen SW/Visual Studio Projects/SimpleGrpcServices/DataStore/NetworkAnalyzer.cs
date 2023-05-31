using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions.DataStore
{
    internal class NetworkAnalyzer : Instrument
    {
        public double frequency { get; set; }
        public double power { get; set; }


        public NetworkAnalyzer(string naName, string ip, double freq, double pow)
        {
            name = naName;
            ipaddress = ip; 
            frequency = freq;
            power = pow;
        }
    }
}
