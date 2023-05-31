using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions.DataStore
{
    internal class Positioner : Instrument
    {
        public double upperlimit { get; set; }
        public double lowerlimit { get; set; }
        public double speed { get; set; }

        public Positioner(string pname, string ip, double ul, double ll, double sp)
        {
            name = pname;
            ipaddress = ip;
            upperlimit = ul;
            lowerlimit = ll;
            speed = sp;
        }
    }
    
    
}
