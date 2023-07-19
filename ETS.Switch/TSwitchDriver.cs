using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Switch
{
    public interface ITSwitchDriver
    {
        void DoOnSubsequentInit();
        //void SetStateVector(int iState);
        List<string> Vstates { get; set; }
        List<int> VstateDelay { get; set; }
        bool StateChanged { get; set; }
        int CurrentStateIndex { get; set; }
        int DebugPolarization { get; set; }
        bool BblankStates { get; set; }
        string States { get; set; }
        long SwitchedTime { get; set; }
        List<string> VstateHolder { get; set; }
    }
    public class TSwitchDriver : TEquipment, ITSwitchDriver
    {

        #region Constructor
        public TSwitchDriver(TParameter[] pPI, int _EOS, uint _timeout, uint _iSlowEquipDelay)
                            : base(pPI, _EOS, _timeout, _iSlowEquipDelay)
        {
            _Init();
        }

        public void _Init()
        {
            DoOnSubsequentInit();
        }
        #endregion


        #region Properties      

        List<string> _vstates { get; set; }
        public List<string> Vstates
        {
            get
            {
                return _vstates;
            }
            set
            {
                _vstates = value;
            }
        }
        List<int> _vstateDelay { get; set; }
        public List<int> VstateDelay
        {
            get
            {
                return _vstateDelay;
            }
            set
            {
                _vstateDelay = value;
            }
        }
        bool _stateChanged { get; set; }
        public bool StateChanged
        {
            get
            {
                return _stateChanged;
            }
            set
            {
                _stateChanged = value;
            }
        }
        int _currentStateIndex { get; set; }
        public int CurrentStateIndex
        {
            get
            {
                return _currentStateIndex;
            }
            set
            {
                _currentStateIndex = value;
            }
        }
        int _debugPolarization { get; set; }
        public int DebugPolarization
        {
            get
            {
                return _debugPolarization;
            }
            set
            {
                _debugPolarization = value;
            }
        }
        string _states { get; set; }
        public string States
        {
            get
            {
                return _states;
            }
            set
            {
                _states = value;
            }
        }
        List<string> _vstateHolder { get; set; }
        public List<string> VstateHolder
        {
            get
            {
                return _vstateHolder;
            }
            set
            {
                _vstateHolder = value;
            }
        }

        bool _bblankStates { get; set; }
        public bool BblankStates
        {
            get
            {
                return _bblankStates;
            }
            set
            {
                _bblankStates = value;
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
        #endregion
        public void DoOnSubsequentInit()
        {
            LoadStateVectors();
            try
            {
                if (Vstates.Count > 0) // if we're configured multi-state then set initial state.
                    SetStateVector(0);
                CurrentStateIndex = -1;
                StateChanged = true;
            }
            catch (Exception)
            {
                // if this fails, it's probably an undefined parameter, meaning we don't have states. No biggie!
                // In C#, empty catch blocks are generally discouraged, but in this specific scenario, it replicates the behavior of catching all exceptions and ignoring them, just like the original C++ code.
            }
        }

        private void LoadStateVectors()
        {
            // Empty vectors, may be loaded from previous run
            Vstates.Clear();
            VstateDelay.Clear();
            // Initialize flags to indicate the currently activated state vector to be undefined
            // StateChange = true ensures that idle time will be attempted for the initial state
            CurrentStateIndex = -1;
            StateChanged = true;

            if (true) // if(mMerge.Isvalid(szSwitchSettings)) This value comes from dwparameter file
            {
                string szStates = ""; // mMerge.GetASParameter(szSwitchSettings); will get value from TParameter class
                szStates = RemoveDuplicateChars(szStates); // szStates.Unique(); // must always do this!
                string[] statesArray = szStates.Split('|');
                foreach (string state in statesArray)
                {
                    Vstates.Add(state);
                }
            }

            if (true) //if (mMerge.IsValid(szSwitchStateDelay))
            {
                string buf = ""; //mMerge.GetASParameter(szSwitchStateDelay); will get value from TParameter class
                buf = RemoveDuplicateChars(buf); // must always do this!
                string[] delayArray = buf.Split('|');
                foreach (string delay in delayArray)
                {
                    VstateDelay.Add(Convert.ToInt32(delay));
                }
            }

            if (BblankStates)
            {
                BlankStates();
            }
        }

        public static string RemoveDuplicateChars(string input)
        {
            return new string(input.Distinct().ToArray());
        }

        private void SetStateVector(int iState)
        {
            try
            {
                DebugPolarization = iState; // It is defind in global file
                if (iState >= Vstates.Count)
                {
                    throw new NotImplementedException(); //throw new TWCExceptions("Undefined Switch State");
                }

                string states = Vstates[iState];
                SetStateVector(states);

                if (iState != CurrentStateIndex)
                {
                    CurrentStateIndex = iState;
                    StateChanged = true;
                }
                else
                {
                    StateChanged = false;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void SetStateVector(string states)
        {
            try
            {
                // I'm just going to send the data and handle whether it's appropriate data in the derived classes
                int x, n = 0; //ReturnPortCount(); Need to get from TMultiSwitchHybrid
                for (x = 0; x < n; x++)
                {
                    if (string.IsNullOrEmpty(states))
                        break;

                    int stateValue = states[0] - '0'; // Convert the character to an integer by subtracting the ASCII value of '0'
                    SetState(x, stateValue);

                    states = states.Substring(1); // Move to the next character
                }
                SwitchedTime = Environment.TickCount; // for cascaded delays (equivalent of timeGetTime())
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        void SetState(int x, int stateChar)
        {
            // Convert the character representing a digit to its integer value
            if (int.TryParse(stateChar.ToString(), out int stateInt))
            {
                // Call the SetState method with the integer state value
                SetState(x, stateInt);
            }
            else
            {
                // Handle the case where the character is not a valid digit (optional)
                // For example, you might throw an exception or provide a default value.
            }
        }


        //private void SetBlankState() { BblankStates = true; }

        public void ResetStates()
        {
            try
            {
                if (VstateHolder.Count == 0) // never went through "BlankStates()"
                    return;

                Vstates.Clear();
                foreach (var state in VstateHolder)
                {
                    Vstates.Add(state);
                }

                VstateHolder.Clear();
                BblankStates = false;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void BlankStates()
        {
            try
            {
                VstateHolder.Clear();
                foreach (var state in Vstates)
                {
                    VstateHolder.Add(state);
                }
                Vstates.Clear();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
       
    }
}
