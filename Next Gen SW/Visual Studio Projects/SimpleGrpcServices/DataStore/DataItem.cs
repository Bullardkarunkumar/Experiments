using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions.DataStore
{
    public class DataItem
    {
        public double frequency { get; set; }
        public string polarization   { get; set; }
        public double theta { get; set; }
        public double phi { get; set; }
        public double value1 { get; set; }
        public double value2 { get; set; }

    }
}
