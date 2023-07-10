using System.Xml;

namespace ETSGrpcPositioner.Positioner
{
    public class ETSPositionerSpecificProperties 
    {
        public ETSPositionerSpecificProperties()
        {
        }

        public string ParamsString
        {
            get
            {
                return string.Empty; // TODO:
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
        }
    }
}
