using System.Xml;
using Parameters;
using Parameters.ps;

namespace ETSGrpcPositioner.Positioner
{
    public class ETSPositionerSpecificProperties 
    {
        public ETSPositionerSpecificProperties()
        {
        }

        public Parameters2 Params { get; set; } 


        public string ParamsString
        {
            get
            {
                return Params.SaveToString(true);
            }

            set
            {
                InitParams(value);
            }

        }

        public string AxisNumber()
        {
            return "1";
        }

        /// <summary>
        /// Initialize the parameter object from a string
        /// </summary>
        /// <param name="parmString">the string</param>
        public void InitParams(string parmString)
        {
            var obj =Parameters2.LoadFromString(parmString);
            if (obj != null) 
            { 
                Params = obj;
            }
        }
    }
}
