using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ETSGrpcPositioner.Positioner
{

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SimulatedPositionerSpecificProperties 
    {
        /// <summary>
        /// Need this to prevent property grid from displaying the class name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Empty;
        }

        /// <summary>
        /// Returns a flag indicating whether the object is valid
        /// </summary>
        /// <returns>true if valid</returns>
        public bool IsValid()
        {
            return true;
        }

    }
}
