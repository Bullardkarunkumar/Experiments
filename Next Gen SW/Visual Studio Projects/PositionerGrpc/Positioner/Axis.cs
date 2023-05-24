using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace Positioner
{
    /// <summary>
    /// Absract class that defines an axis or positioner
    /// </summary>
    public abstract class Axis
    {

        #region Constants and Fields

        IConnection _posConnection;

        // settings
        protected AxisType _axisMotion;   //Rotational or Linear    
        protected AxisRotation _rotationMode; //positions are from 0 to 359.9 wrapping around at 0 and 359.9, limits if set are ignored      
        // in non-continuous mode, positions moves between limits. The limits are between -999.9 and +999.9 
        protected double _currentPosition = 0.0;        
        protected double _cwOrUpperLimit = 360.0;
        protected double _ccwOrLowerLimit = 0.0;
        protected double _acceleration = 1000; //in ms
        protected double _scanCycles = 10.0; // in steps of .5 
              
        //speed
        protected double _maxSpeed;  // degrees per second
        protected int _currentSpeedIndex = 2; //current speed's index in the SpeedSettings array - 0 to 8         
        private int[] _speedSettings = new int[] {32, 64, 96, 128, 159, 190, 223, 255};
        protected double[] _speedSettingsPercent = new double[] {12.5F, 25.0F, 37.5F, 50.0F, 62.5F, 75.0F, 87.5F, 100.0F};                       
        
        //id
        protected string _name;
        
        //errors              
        private bool _executionError;
        private string _errorMessage;

        #endregion

        #region Constructors
        public Axis()
        {

        }
       
        #endregion

        #region Public Properties
        public IConnection PosConnection
        {
            get { return _posConnection; }
            set { _posConnection = value; }
        }
        #endregion

        #region Enumerators
        public enum AxisType
        {
            Rotational,
            Linear
        }
        public enum AxisRotation
        {
            NonContinuous,
            Continuous
        }
        public enum MotionDir
        {
            CCWorDown = -1,
            Stopped = 0,
            CWorUp = 1
        }
      
        #endregion
        #region Public  Abstract Properties

        public abstract AxisRotation RotationMode
        {
            get;
            set;
        }

        public abstract double CurrentPosition
        {
            get;
            set;
        }

        public abstract double CwLimit
        {
            get;
            set;
        }

        public abstract double CcwLimit
        {
            get;
            set;
        }
       
        public abstract double AccelerationInMS
        {
            get;
            set;
        }

        public abstract double ScanCycles
        {
            get;
            set;
        }

        public abstract int CurrentSpeed// 1, 2 ... S
        {
            get;
            set;
        }

        public abstract bool OperationComplete
        {
            get;

        }

        public abstract int Direction
        {
            get;
        }

        public abstract bool IsHomed
        {
            get;
        }

        public abstract bool Scanning
        {
            get;
        }

        public abstract bool Homing
        {
            get;
        }

        #endregion

        #region Public Properties
        public string AxisMotion
        {
            get
            {
                return (_axisMotion == AxisType.Linear) ? "1" : "0";
            }
            set
            {
                _axisMotion = (value.Trim() == "1") ? AxisType.Linear : AxisType.Rotational;
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
                      
        public double UpperLimit
        {
            get { return CwLimit; }
            set { CwLimit = value; }
        }
        
        public double LowerLimit
        {
            get { return CcwLimit; }
            set { CcwLimit = value; }
        }
                     
        public bool IsConnected
        {
            get { return PosConnection.IsConnected(); }
        }

        public double MaxSpeed
        {
            get { return _maxSpeed; }
        }
                                                    
        #endregion
       
        public string ErrorMessage
        {
            get { return _errorMessage; }
        }
        
        public bool ExecutionError
        {
            get { return _executionError; }
        }

        #region Abstract methods to be implemented by the subclass
        public abstract void SetDevice(string addr);
        public abstract  bool InitDeviceSpecific();              
        public abstract string Seek(double position);                                                  
        public abstract string SeekPositive(double position);                                       
        public abstract string SeekNegative(double position);                           
        //public string SeekRelative(string distance);
        public abstract string Clockwise();
        public abstract string CounterClockwise();
        public abstract string Stop();        
        public abstract string Scan();
        public abstract bool Home();
        public abstract string GetDeviceError();
        public abstract void ClearDeviceError();        
                
        #endregion
        
        #region Completed Methods

        public virtual string GetIDN()
        {
            return Name;
        }

        public bool ConnectToDevice(string addr)
        {
            SetDevice(addr);
            if (_posConnection.ConnectToDevice())
            {
                InitCommon();
                if (!InitDeviceSpecific())
                {
                    _posConnection.CloseConnection();
                    return false;
                }
                return true;
            }
            
            return false;
        }

        public void InitCommon()
        {
        }

        //public void SetSpeedSetting(int indx, int val)
        //{
        //    if ((val < 0) || (val > 255))
        //        SetErrorMessage("ERROR:Value out of range");
        //    if ((indx < 1) || (indx > 8))
        //        SetErrorMessage("ERROR:Speed index out of range");
        //    _speedSettings[indx - 1] = val;
        //    //speedSettingsDPS[indx-1] = MinSpeed + ((MaxSpeed - MinSpeed) * val / 255.0);           
        //}

        //public int GetSpeedSetting(int indx)
        //{
        //    if ((indx < 1) || (indx > 8))
        //        return 0;

        //    return _speedSettings[indx - 1];
        //}

        public virtual void SetSpeedSettingPercent(int setting, double val)
        {
            if ((val < 1) || (val > 100))
            {
                SetErrorMessage("Value out of range");
                return;
            }
            if ((setting < 1) || (setting > 8))
            {
                SetErrorMessage("Speed setting out of range");
                return;
            }
            _speedSettingsPercent[setting - 1] = val;          
            //speedSettingsDPS[indx-1] = MinSpeed + ((MaxSpeed - MinSpeed) * val / 255.0);           
        }

        public double GetSpeedSettingPercent(int setting)
        {
            if ((setting < 1) || (setting > 8))
            {
                SetErrorMessage("Value out of range");
                return 0;
            }

            return _speedSettingsPercent[setting - 1];
        }

        public void ClearErrorMessage()
        {
            _executionError = false;
            _errorMessage = String.Empty;
        }

        protected void SetErrorMessage(string errMsg)
        {
            _executionError = true;
            _errorMessage = errMsg;
        }

        #endregion
    }
}
