using Parameters.ps;
using System.Xml;
using static Parameters.ps.Parameters2;
using static Parameters.ps.ParameterType;

namespace ETSGrpcPositioner.Positioner
{
    public class ETSPositionerSpecificProperties 
    {
        public ETSPositionerSpecificProperties()
        {
        }

        public Parameters.ps.Parameters2 Params { get; set; } 


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
            if (Params != null)
            {
                foreach (ParametersType p in Params.Parameters3)
                {
                    foreach (ParameterType parameterType in p.Parameter)
                    {
                        var props = parameterType.Property;

                        foreach (PropertyType prop in props)
                        {
                            string val = prop.Value2.First.StringValue.First.Value;
                            return val;
                        }
                    }
                }
            }
            
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
