using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ETS.SwitchFramework;

namespace ETS.Switch
{
    public interface ITemSwitch
    {
        TModuleInfo[] GetModuleTypeInfo();
        void DoOnFirstInit();
        int GetState(int switchNum);
        void SetStateVector(char[] states);
        string GetStateVector();
        int CheckInterlock();

        bool MbIsVISA { get; set; }
        string Config { get; set; }
        int SlotNum { get; set; }
        int EmcenterNum { get; set; }
        int ModuleIndex { get; set; }
        int TotalSwitchCount { get; set; }
        int SwitchCount { get; set; }
        string SrcName { get; set; }
        bool UseShadow { get; set; }
        long SwitchedTime { get; set; }
        string ExEquipName { set; get; }
        string EquipmentName { set; get; }
        bool BVisaAsyncLocalOverride { get; set; }
        TModuleInfo[] Modules { get; set; }
        Dictionary<int, int> StateShadow { get; set; }
        TModuleInfo[] ModuleTypeInfo { get; set; }
        int[] ModuleInfoIndex { get; set; }
    }
    public class TemSwitch : TSwitchDriver, ITemSwitch
    {
        TSwitchDriver switchDriver;
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TemSwitch"/> class.
        /// </summary>
        /// <param name="pPI"></param>
        public TemSwitch(TParameter[] pPI) : base(pPI, 0, 10000, 0)
        {
            switchDriver = new TSwitchDriver(pPI, 0, 1000, 0);
            /// <summary>
            /// _inits this instance.
            /// </summary>
            _init();
        }

        public void _init()
        {
            //Default values 
            SlotNum = 1;
            EmcenterNum = 0;
            ModuleIndex = 0;
            TotalSwitchCount = 0;
            SwitchCount = 0;
            StateShadow = new Dictionary<int, int>();
            SwitchedTime = 0;
            EquipmentName = "";//Need to give Equipment Name
            ExEquipName = " for device \"" + EquipmentName + "\"";
            BVisaAsyncLocalOverride = false;// This value should come from Equipment class
            TParameter parameter = new TParameter();
            MbIsVISA = true;// it should come from Equipment class
            if (MbIsVISA)
            {
                SrcName = "TCPIP::" + parameter.GetASParameter(TDataAwareTypes.szIPAddress) + "::INSTR";
            }
            Config = parameter.GetASParameter(TDataAwareTypes.szUserInitConfig, ParametersTypeInfo.DEFAULT_CONFIG_STRING);
            SetModuleTypeInfo();
            Modules = SetModules();
        }

        #endregion

        #region Properties
        bool _mbIsVISA { get; set; }
        virtual public bool MbIsVISA
        {
            get
            {
                return _mbIsVISA;
            }
            set
            {
                _mbIsVISA = value;
            }
        }

        string _config { get; set; }
        public string Config
        {
            get
            {
                return _config;
            }
            set
            {
                _config = value;
            }
        }

        int _slotNum { get; set; }
        virtual public int SlotNum
        {
            get
            {
                return _slotNum;
            }
            set
            {
                _slotNum = value;
            }
        }

        int _emCenterNum { get; set; }
        virtual public int EmcenterNum
        {
            get
            {
                return _emCenterNum;
            }
            set
            {
                _emCenterNum = value;
            }
        }

        int _moduleIndex { get; set; }
        virtual public int ModuleIndex
        {
            get
            {
                return _moduleIndex;
            }
            set
            {
                _moduleIndex = value;
            }
        }

        int _totalSwitchCount { get; set; }
        virtual public int TotalSwitchCount
        {
            get
            {
                return _totalSwitchCount;
            }
            set
            {
                _totalSwitchCount = value;
            }
        }

        int _switchCount { get; set; }
        virtual public int SwitchCount
        {
            get
            {
                return _switchCount;
            }
            set
            {
                _switchCount = value;
            }
        }

        string _srcName { get; set; }
        virtual public string SrcName
        {
            get
            {
                return _srcName;
            }
            set
            {
                _srcName = value;
            }
        }

        TModuleInfo[] _modules { get; set; }
        public TModuleInfo[] Modules
        {
            get
            {
                return _modules;
            }
            set
            {
                _modules = value;
            }
        }
        Dictionary<int, int> _stateShadow { get; set; }
        public Dictionary<int, int> StateShadow
        {
            get
            {
                return _stateShadow;
            }
            set
            {
                _stateShadow = value;
            }
        }
        TModuleInfo[] _moduleTypeInfo { get; set; }
        public TModuleInfo[] ModuleTypeInfo
        {
            get
            {
                return _moduleTypeInfo;
            }
            set
            {
                _moduleTypeInfo = value;
            }

        }
        int[] _moduleInfoIndex { get; set; }
        public int[] ModuleInfoIndex
        {
            get
            {
                return _moduleInfoIndex;
            }
            set
            {
                _moduleInfoIndex = value;
            }

        }

        bool _useShadow { get; set; }
        public bool UseShadow
        {
            get
            {
                return _useShadow;
            }
            set
            {
                _useShadow = value;
            }
        }
        long _switchedTime { get; set; }
        public long SwitchedTime
        {
            get
            {
                return _switchedTime;
            }
            set
            {
                _switchedTime = value;
            }
        }

        string _exEquipName { get; set; }
        public string ExEquipName
        {
            get
            {
                return _exEquipName;
            }
            set
            {
                _exEquipName = value;
            }
        }
        string _equipmentName { get; set; }
        public string EquipmentName
        {
            get
            {
                return _equipmentName;
            }
            set
            {
                _equipmentName = value;
            }
        }
        bool _bVisaAsyncLocalOverride { get; set; }
        public bool BVisaAsyncLocalOverride
        {
            get
            {
                return _bVisaAsyncLocalOverride;
            }
            set
            {
                _bVisaAsyncLocalOverride = value;
            }
        }


        #endregion

        #region Methods
        private void SetModuleTypeInfo()
        {

            ModuleTypeInfo = new TModuleInfo[] {
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_Unused, RelayCount = 0, StateCount = 0, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_2XSP2T, RelayCount = 2, StateCount = 2, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_4XSP2T, RelayCount = 4, StateCount = 2, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_2XSP6T, RelayCount = 2, StateCount = 6, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_EMControl, RelayCount = 4, StateCount = 2, FirstState =0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_1XSP6T, RelayCount = 1, StateCount = 6, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0},
                new TModuleInfo { ModuleType = TEMSModuleType.EMSType_1XSP2T, RelayCount = 1, StateCount = 2, FirstState = 0, EMCSlotNum=0, EMCenterNum = 0, FirstSwitchNum=0}
            };
        }
        private TModuleInfo[] SetModules()
        {
            // Fill 'Modules' with information about plug-ins in each slot
            int i = 1;
            while (i < ParametersTypeInfo.MAX_EMCENTER_SLOTS + ParametersTypeInfo.MAX_EMCENTERS)
            {
                if (Config[i] == '|')
                {
                    i++;
                    SlotNum = 1;
                    EmcenterNum++;
                    continue;
                }
                Modules[ModuleIndex] = ModuleTypeInfo[Config[i] - '0'];   // Copy info on the selected module
                Modules[ModuleIndex].EMCenterNum = EmcenterNum;
                Modules[ModuleIndex].EMCSlotNum = SlotNum;
                Modules[ModuleIndex].FirstSwitchNum = TotalSwitchCount;
                // save the switch's module index for later use
                for (int x = 0; x < Modules[ModuleIndex].RelayCount; x++)
                {
                    ModuleInfoIndex = ModuleInfoIndex.Append(ModuleIndex).ToArray();
                }
                TotalSwitchCount += Modules[ModuleIndex].RelayCount;
                ModuleIndex++;
                SlotNum++;
                i++;
            }
            SwitchCount = TotalSwitchCount;
            StateShadow.Clear();
            UseShadow = false;
            return Modules;
        }
        public TModuleInfo[] GetModuleTypeInfo()
        {
            return ModuleTypeInfo;
        }

        public void DoOnFirstInit()
        {
            try
            {
                try
                {
                    // Verify the presence of the correct EMSwitch cards in the EMCenters, i.e., verify the configuration
                    VerifyIDN();
                }
                catch (Exception e)
                {
                    // This is just a VISA catch to see if running in synchronous mode fixes the problem
                    if (!MbIsVISA)
                    {
                        string err = string.Format("Failed getting DoOnFirstInit: {0}", e);
                        Trace.WriteLine(err);
                        SetErrorMessage(err);
                    }
                    BVisaAsyncLocalOverride = false;
                }
                if (!BVisaAsyncLocalOverride)
                    VerifyIDN();

                DoOnSubsequentInit();
            }
            catch (Exception e)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format("Failed getting DoOnFirstInit next time: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        public void DoOnSubsequentInit()
        {
            try
            {
                UseShadow = false;
                StateShadow.Clear();
                switchDriver.DoOnSubsequentInit();
                if (!BblankStates)
                    UseShadow = true;
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format("Failed getting DoOnFirstInit next time: {0}", ex);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        public int GetState(int switchNum)
        {
            try
            {
                if (switchNum >= ModuleInfoIndex.Count())
                {
                    string err = "Switch number is greater than configured number of switches";
                    Trace.WriteLine(err);
                    SetErrorMessage(err);
                }

                int moduleIndex = ModuleInfoIndex[switchNum]; // find out which module this is in
                int switchOffset = switchNum - Modules[moduleIndex].FirstSwitchNum; // and which switch in that module

                return GetState(moduleIndex, switchOffset);
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return -1;
        }

        public int GetState(int moduleIndex, int switchNum)
        {
            try
            {
                return GetState(Modules[moduleIndex].EMCenterNum, Modules[moduleIndex].EMCSlotNum, switchNum, (int)Modules[moduleIndex].ModuleType);
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return -1;
        }

        public int GetState(int emcenterNum, int emcenterSlot, int switchNum, int switchType)
        {
            try
            {
                string result = "";
                int address = emcenterNum * 10 + emcenterSlot;

                if (switchType == (int)TEMSModuleType.EMSType_EMControl)
                {
                    if ((switchNum == 0) || (switchNum == 1)) // AUX port
                    {
                        result = string.Format("{0}AUX{1}?", address, switchNum + 1); // query the port setting and convert to an integer
                    }
                    else if (switchNum == 2) // Pol switch on Device A
                    {
                        result = string.Format("{0}AP?", address); // query the port setting and convert to an integer
                    }
                    else if (switchNum == 3) // Pol switch on Device B
                    {
                        result = string.Format("{0}BP?", address); // query the port setting and convert to an integer
                    }
                }
                else
                {
                    char switchChar = (char)(switchNum + 'A'); // convert 0 to A, 1 to B, etc.
                    result = string.Format("{0}:INT_RELAY_{1}?", address, switchChar); // query the port setting and convert to an integer
                }

                int currentState = GetStateFromResult(result, switchType);

                int globalSwitchNum = address * 10 + switchNum;
                StateShadow[globalSwitchNum] = currentState;

                return currentState;
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return -1;
        }

        public int GetStateFromResult(string result, int switchType)
        {
            int res = 0;
            try
            {
                if (string.IsNullOrEmpty(result))
                    return 9;
                if (result.StartsWith("ERROR_205")) // Interlock error
                {
                    res = 0; // state is NC
                    return res;
                }
                else if (result.StartsWith("ERROR"))
                {
                    res = 9;
                    return res;
                }

                result = result.Trim(); // remove the \n or \r\n at the end

                if (switchType == (int)TEMSModuleType.EMSType_EMControl)
                {
                    res = int.Parse(result);
                }
                else if (switchType == (int)TEMSModuleType.EMSType_2XSP6T || switchType == (int)TEMSModuleType.EMSType_1XSP6T)
                {
                    res = int.Parse(result) - 1;
                }
                else
                {
                    if (result == "NC")
                        res = 0;
                    else if (result == "NO")
                        res = 1;
                    else
                        res = 9; // not a valid state
                }
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return res;
        }

        public string GetStateStrFromState(int iState, int switchType)
        {
            string result = "";
            try
            {
                if (switchType == (int)TEMSModuleType.EMSType_EMControl)
                {
                    switch (iState)
                    {
                        case 0:
                            result = "OFF";
                            break;
                        case 1:
                            result = "ON";
                            break;
                    }
                }
                else if (switchType == (int)TEMSModuleType.EMSType_2XSP6T || switchType == (int)TEMSModuleType.EMSType_1XSP6T)
                {
                    result = (iState + 1).ToString();
                }
                else
                {
                    switch (iState)
                    {
                        case 0:
                            result = "NC";
                            break;
                        case 1:
                            result = "NO";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception here
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return result;
        }

        public int ReturnPortCount()
        {
            return SwitchCount;
        }

        public void SetState(int switchNum, int iState)
        {
            try
            {
                if (switchNum >= ModuleInfoIndex.Count())
                {
                    string err = "Switch number is greater than configured number of switches";
                    Trace.WriteLine(err);
                    SetErrorMessage(err);
                }
                int moduleIndex = ModuleInfoIndex[switchNum]; // find out which module this is in
                int switchOffset = switchNum - Modules[moduleIndex].FirstSwitchNum; // and which switch in that module

                SetState(moduleIndex, switchOffset, iState);
            }
            catch (Exception)
            {
                // Handle or rethrow the exception as needed
                string err = "SetState with switchNum with iState";
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        public void SetState(int moduleIndex, int switchNum, int iState)
        {
            try
            {
                int type = (int)Modules[moduleIndex].ModuleType;
                if ((iState > 1) && ((type == (int)TEMSModuleType.EMSType_1XSP2T) || (type == (int)TEMSModuleType.EMSType_2XSP2T) || (type == (int)TEMSModuleType.EMSType_4XSP2T) || ((type == (int)TEMSModuleType.EMSType_EMControl) && (switchNum < 2))))
                    return;
                if ((iState > 2) && ((type == (int)TEMSModuleType.EMSType_EMControl) && (switchNum >= 2)))
                    return;
                if ((iState > 5) && (type == (int)TEMSModuleType.EMSType_2XSP6T || type == (int)TEMSModuleType.EMSType_1XSP6T))
                    return;

                SetState(Modules[moduleIndex].EMCenterNum, Modules[moduleIndex].EMCSlotNum, switchNum, type, iState);
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format("SetState with moduleIndex , switchNum with iState: {0}", ex);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        public void SetState(int emcenterNum, int emcenterSlot, int switchNum, int switchType, int state)
        {
            string result = "";
            try
            {
                string cmd;
                int address = emcenterNum * 10 + emcenterSlot;
                int globalSwitchNum = address * 10 + switchNum;


                if (UseShadow)
                {
                    int prevState;
                    if (StateShadow.TryGetValue(globalSwitchNum, out prevState))
                    {
                        if (prevState == state) // state same as before
                            return;
                    }
                    StateShadow[globalSwitchNum] = state;
                }

                for (int retry = 0; retry < 5; retry++)
                {
                    //string result;
                    if (switchType == (int)TEMSModuleType.EMSType_EMControl)
                    {
                        if ((switchNum == 0) || (switchNum == 1)) // AUX port
                        {
                            string stateStr = GetStateStrFromState(state, switchType);
                            result = string.Format("{0}AUX{1} {2}", address, switchNum + 1, stateStr); // set state
                            result = string.Format("{0}AUX{1}?", address, switchNum + 1); // query the port setting and convert to an integer
                        }
                        else if (switchNum == 2) // Pol switch on Device A
                        {
                            if (state == 2)
                                result = string.Format("{0}AP2", address); // set bypass
                            else if (state == 1)
                                result = string.Format("{0}APH", address); // set horizontal
                            else if (state == 0)
                                result = string.Format("{0}APV", address); // vertical
                            result = string.Format("{0}AP?", address); // query the port setting and convert to an integer
                        }
                        else if (switchNum == 3) // Pol switch on Device B
                        {
                            if (state == 2)
                                result = string.Format("{0}BP2", address); // set bypass
                            else if (state == 1)
                                result = string.Format("{0}BPH", address); // set horizontal
                            else if (state == 0)
                                result = string.Format("{0}BPV", address); // set vertical
                            result = string.Format("{0}BP?", address); // query the port setting and convert to an integer
                        }
                    }
                    else
                    {
                        char switchChar = (char)(switchNum + 'A'); // convert 0 to A, 1 to B, etc.
                        string stateStr = GetStateStrFromState(state, switchType);
                        result = string.Format("{0}:INT_RELAY_{1}_{2}", address, switchChar, stateStr); // set the state
                        result = string.Format("{0}:INT_RELAY_{1}?", address, switchChar); // query the port setting and convert to an integer
                    }

                    if (result.StartsWith("ERROR"))
                    {
                        // Handle or rethrow the exception as needed
                        Trace.WriteLine(result);
                        SetErrorMessage(result);
                    }

                    Thread.Sleep(50);

                    int currentState = GetStateFromResult(result, switchType);
                    if (currentState == state)
                        return;
                }

                string err = "Unable to set switch to target state";
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                Trace.WriteLine(ex);
                SetErrorMessage(ex.ToString());
            }
        }

        public void SetStateVector(char[] states)
        {
            try
            {
                int x = 0;
                int n = ReturnPortCount();
                while (x < n)
                {
                    if (states[x] == '\0')
                        break;
                    if ((states[x] != '*') && (states[x] != ','))
                    {
                        SetState(x, states[x] - 0x30);
                        x++;
                    }
                    x++;
                }
                SwitchedTime = DateTime.Now.Millisecond; // for cascaded delays
            }
            catch (Exception ex)
            {
                // Handle exception
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        public string GetStateVector()
        {
            try
            {
                int n = ReturnPortCount();
                int count = 0;
                StringBuilder stateVector = new StringBuilder();
                for (int i = 0; i < ParametersTypeInfo.MAX_EMCENTER_SLOTS; i++)
                {
                    if (count >= n)
                        break;
                    if (Modules[i].ModuleType == TEMSModuleType.EMSType_Unused)
                    {
                        stateVector.Append("*,"); // place holder for empty slot
                        continue;
                    }
                    for (int x = 0; x < Modules[i].RelayCount; x++)
                    {
                        count++;
                        int state = GetState(i, x);
                        stateVector.Append(state);
                    }
                    stateVector.Append(",");
                }
                return stateVector.ToString();
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return string.Empty;
        }

        public int CheckInterlock()
        {
            for (int i = 0; i < ParametersTypeInfo.MAX_EMCENTER_SLOTS; i++)
            {
                if (Modules[i].ModuleType == TEMSModuleType.EMSType_Unused || Modules[i].ModuleType == TEMSModuleType.EMSType_EMControl)
                    continue;
                int address = Modules[i].EMCenterNum * 10 + Modules[i].EMCSlotNum;
                string result = string.Format("{0}:INT_RELAY_A?", address);
                if (result.Contains("ERROR_205"))
                    return 1;
            }
            return 0;
        }

        /// <summary>
        /// Verifies the identity of the switch plug-in in the slot with the configuration
        /// </summary>
        private void VerifyIDN()
        {
            try
            {
                for (int i = 0; i < ParametersTypeInfo.MAX_EMCENTER_SLOTS; i++)
                {
                    if (Modules[i].ModuleType == TEMSModuleType.EMSType_Unused)
                        continue;

                    int address = Modules[i].EMCenterNum * 10 + Modules[i].EMCSlotNum;
                    string idn = string.Format("{0}:*IDN?", address);

                    bool error = false;
                    switch (Modules[i].ModuleType)
                    {
                        case TEMSModuleType.EMSType_2XSP2T:
                            if ((idn.IndexOf("EMSwitch 7001-001") < 0) && (idn.IndexOf("EMSwitch 7001-011") < 0) &&
                                (idn.IndexOf("EMSwitch 7001-023") < 0) && (idn.IndexOf("EMSwitch 7001-026") < 0))
                                error = true;
                            break;
                        case TEMSModuleType.EMSType_4XSP2T:
                            if ((idn.IndexOf("EMSwitch 7001-002") < 0) && (idn.IndexOf("EMSwitch 7001-024") < 0) &&
                                (idn.IndexOf("EMSwitch 7001-012") < 0) && (idn.IndexOf("EMSwitch 7001-027") < 0))
                                error = true;
                            break;
                        case TEMSModuleType.EMSType_2XSP6T:
                            if ((idn.IndexOf("EMSwitch 7001-003") < 0) && (idn.IndexOf("EMSwitch 7001-013") < 0))
                                error = true;
                            break;
                        case TEMSModuleType.EMSType_EMControl:
                            if ((idn.IndexOf("ETS-Lindgren, EMControl") < 0) && (idn.IndexOf("D.A.R.E!!, RadiControl") < 0))
                                error = true;
                            break;
                        case TEMSModuleType.EMSType_1XSP6T:
                            if ((idn.IndexOf("EMSwitch 7001-005") < 0) && (idn.IndexOf("EMSwitch 7001-025") < 0))
                                error = true;
                            break;
                        case TEMSModuleType.EMSType_1XSP2T:
                            if (idn.IndexOf("EMSwitch 7001-021") < 0)
                                error = true;
                            break;
                    }
                    if (error)
                    {
                        string err = @"A valid EMSwitch was not found in EMCenter: " + Modules[i].EMCenterNum +
                                        " Slot: " + Modules[i].EMCSlotNum + ExEquipName +
                                        "  Received \"" + idn + "\" for an ID string.";
                        Trace.WriteLine(err);
                        SetErrorMessage(err);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or rethrow the exception as needed
                string err = string.Format(ex.ToString());
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
        }

        #endregion
    }
}
