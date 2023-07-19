using ETS.SwitchFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Switch
{
    public class TParameter
    {

        private List<SEnumText> VEnumText = new List<SEnumText>();

        // string to hold path to this TParameter in its parent tree
        // This path is developed at runtime and NOT stored!
        public string DataPath { get; set; }

        public int iLinearIdx { get; set; }

        // For exporting to the EMQuest Executive
        public bool bOverwriteOnMerge { get; set; }

        //private int storagesize;
        ////private TThreadSafeBaseCal pTSBCal;

        //// vectors to hold enums/type
        //private List<short> vStr = new List<short>();        // String
        //private List<short> vInt = new List<short>();        // Integers
        //private List<short> vDbl = new List<short>();        // Doubles
        //private List<short> vBool = new List<short>();       // Booleans
        //private List<short> vTParameter = new List<short>();
        //private List<short> vPAParameter = new List<short>();
        //private List<short> vXYZArray = new List<short>();
        //private List<short> vVPArray = new List<short>();

        //// vectors to hold data
        //private List<string> dStr = new List<string>();
        //private List<int> dInt = new List<int>();
        //private List<double> dDbl = new List<double>();
        //private List<bool> dBool = new List<bool>();
        //private List<TParameter> dTParameter = new List<TParameter>();
        //private List<List<TParameter>> dPAParameter = new List<List<TParameter>>();
        ////private List<TXYZArray> dXYZArray = new List<TXYZArray>();
        //private List<List<char>> dVPArray = new List<List<char>>();

        //// property vector(s)
        //private List<short> vControlRequired = new List<short>();

        // private storage members
        public void SetASParameter(TDataAwareTypes src, string str)
        {
            SetParameter(src, str);
        }

        public string GetASParameter(TDataAwareTypes src)
        {
            return GetSzParameter(src);
        }
        public string GetASParameter(TDataAwareTypes src, string Default)
        {
            return GetSzParameter(src, Default);
        }

        public string GetSzParameter(TDataAwareTypes src)
        {
            // Logic to retrieve the parameter value
            return "";
        }

        public string GetSzParameter(TDataAwareTypes src, string Default)
        {
            // Logic to retrieve the parameter value with a default value
            return "";
        }
        //	These next 6 functions return 0 on success, -1 on failure
        public void SetParameter(TDataAwareTypes src, string str)
        {
            // Logic to set the parameter value
        }
        public void VISASet(string srcName, bool bFlag = true)
        {
            //m_VIRsrcName = srcName;
            //m_bIsVISA = bFlag;
        }
    }
}
public class SEnumText
{
    public TDataAwareTypes eParamEnum;
    public string ASParamValue;
}


