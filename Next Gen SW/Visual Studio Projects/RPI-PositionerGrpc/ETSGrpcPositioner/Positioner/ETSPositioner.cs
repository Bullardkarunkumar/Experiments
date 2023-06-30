using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Timers;
using Ets.Instrument;
using System.Reflection.Metadata.Ecma335;

namespace ETSGrpcPositioner.Positioner
{
    public class ETSPositioner : Axis
    {

        #region Constructors

        /// <summary>
        /// Default constructor needed for dependency injection
        /// </summary>
        public ETSPositioner()
        {
            this.AxisSpecificProperties = new ETSPositionerSpecificProperties();
            _prefix = "1";
        }

        #endregion

        #region Public Overriden Properties of Axis

        public override AxisRotation RotationMode
        {
            get
            {
                return _rotationMode;
            }
            set
            {
                _rotationMode = value;
                string cmd = (_rotationMode == AxisRotation.Continuous) ? "CR" : "NCR";
                WriteToPositioner(cmd);

            }
        }

        public override double CurrentPosition
        {
            get
            {
                string response = String.Empty;
                string cmd = "CP?";
                string cpos = QueryPositioner(cmd);
                if (cpos != String.Empty)
                    _currentPosition = Convert.ToDouble(cpos);

                return _currentPosition;
            }

            set
            {
                _currentPosition = value;
                string cmd = String.Format("CP {0}", _currentPosition);
                WriteToPositioner(cmd);
            }
        }
        public override double TargetPosition
        {
            get
            {
                return _targetPosition;
            }
            set
            {
                _targetPosition = value;
            }
        }

        public override double CwLimit
        {
            get
            {
                string response = String.Empty;
                string cmd = "UL?";
                string lim = QueryPositioner(cmd);
                if (lim != String.Empty)
                    _cwOrUpperLimit = Convert.ToDouble(lim);
                return _cwOrUpperLimit;
            }
            set
            {
                _cwOrUpperLimit = value;
                string cmd = String.Format("UL {0}", _cwOrUpperLimit);
                WriteToPositioner(cmd);
            }
        }

        public override double CcwLimit
        {
            get
            {
                string response = String.Empty;
                string cmd = "LL?";
                string lim = QueryPositioner(cmd);
                if (lim != String.Empty)
                    _ccwOrLowerLimit = Convert.ToDouble(lim);
                return _ccwOrLowerLimit;
            }
            set
            {
                _ccwOrLowerLimit = value;
                string cmd = String.Format("LL {0}", _ccwOrLowerLimit);
                WriteToPositioner(cmd);
            }
        }

        public override double AccelerationInMS
        {
            get
            {
                string response = String.Empty;
                string acc = QueryPositioner("A?");
                if (acc != String.Empty)
                    _acceleration = Convert.ToInt32(acc);
                return _acceleration;
            }
            set
            {
                _acceleration = value;
                string cmd = String.Format("A {0}", _acceleration);
                WriteToPositioner(cmd);
            }
        }

        public override double ScanCycles
        {
            get;
            set;
        }

        public override int CurrentSpeed// 1, 2 ... S
        {
            get
            {

                return _currentSpeedIndex + 1;
            }
            set
            {
                if ((value >= 1) && (value <= 8))
                {
                    _currentSpeedIndex = value - 1;
                    string cmd = String.Format("S{0}", value);
                    WriteToPositioner(cmd);
                }
            }

        }

        public override double CurrentVelocity
        {
            get => 0;
            set { }
        }

        public override bool OperationComplete
        {
            get
            {
                if (Direction == 0)
                    return true;
                else
                    return false;
            }

        }

        public override int Direction
        {
            get
            {
                string cpStr = QueryPositioner("DIR?");
                return Convert.ToInt32(cpStr);
            }
        }

        public override bool IsHomed
        {
            get
            {
                string response = String.Empty;

                string hm = QueryPositioner("HOME?");
                if (hm != String.Empty)
                {
                    if (hm.Equals("1")) return true;
                }

                return false;
            }
        }

        public override bool Homing
        {
            get
            {
                return false;
            }
        }

        public override bool Scanning
        {
            get
            {
                return false;
            }
        }

        public override double PositionOffset { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double MaxVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

        #region Private properties specific to ETS Positioner

        private double[] _speedSettingsDegreesPerSec = new double[8];
        private Object readWriteLock = new Object();
        private string _prefix;
        #endregion

        #region Overriden methods of Axis

        /// <summary>
        /// Creates the expected connection
        /// </summary>
        /// <param name="dev">the device</param>
        /// <returns>the connection</returns>
        public override IConnection CreateConnection(Device dev)
        {
            var conn = new SimulatedConnection();

            PosConnection = conn;
            return conn;
        }

        public override string GetIDN()
        {
            try
            {
                string id = QueryPositioner("*IDN?");
                return id;
            }
            catch (Exception e)
            {
                string err = string.Format("Failed getting IDN: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return String.Empty;
        }

        public override void SetDevice(string addr)
        {
            Device dev = MakeDevice(addr);
            PosConnection.SetDevice(dev);
        }

        public override bool InitDeviceSpecific()
        {
            _maxSpeed = 150;  // degrees per second (25 RPM)    

            string id = QueryPositioner("*IDN?");
            if (!(id.Contains("ETS-Lindgren")))
            {
                Trace.WriteLine("Device at this port is not a supported ETS-Lindgren Positioner");
                return false;
            }

            // set upper limit           
            WriteToPositioner("LL -9999");

            // set upper limit         
            WriteToPositioner("UL 9999");

            // set starting speed 
            WriteToPositioner("S2");

            return true;
        }

        public override string Seek(double position)
        {
            try
            {
                double target = position;
                string cmd = String.Format("SK {0}", target);
                WriteToPositioner(cmd);
            }
            catch (Exception e)
            {
                string err = string.Format("Seek failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override string SeekPositive(double position)
        {

            try
            {
                double target = position;
                string cmd = String.Format("SKP {0}", target);
                WriteToPositioner(cmd);
            }
            catch (Exception e)
            {
                string err = string.Format("Seek failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override string SeekNegative(double position)
        {
            try
            {
                double target = position;
                string cmd = String.Format("SKN {0}", target);
                WriteToPositioner(cmd);
            }
            catch (Exception e)
            {
                string err = string.Format("Seek failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override string Clockwise()
        {
            try
            {
                if (_rotationMode == AxisRotation.Continuous)
                    WriteToPositioner("CW");
                else
                    Seek(UpperLimit);
            }
            catch (Exception e)
            {
                string err = string.Format("Clockwise operation failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override string CounterClockwise()
        {
            try
            {
                if (_rotationMode == AxisRotation.Continuous)
                    WriteToPositioner("CC");
                else
                    Seek(LowerLimit);
            }
            catch (Exception e)
            {
                string err = string.Format("Counter Clockwise operation failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override string Stop()
        {
            try
            {
                string cmd = "ST";
                WriteToPositioner(cmd);
            }
            catch (Exception e)
            {
                string err = string.Format("Stop failed: {0}", e);
                Trace.WriteLine(err);
                SetErrorMessage(err);
            }
            return "OK";
        }

        public override void SetSpeedSettingPercent(int setting, double val)
        {
            int settingValue = (int)(val * 255 / 100);
            string cmd = String.Format("SS{0} {1}", setting, settingValue);
            WriteToPositioner(cmd);
            base.SetSpeedSettingPercent(setting, val);

            if (_currentSpeedIndex == (setting - 1))
                CurrentSpeed = setting; // reset current speed since the setting % value has changed
        }

        public override string Scan()
        {
            return "OK";
        }

        public override bool Home()
        {
            WriteToPositioner("HOME");
            int waitTime = 0;
            while (true)
            {
                Thread.Sleep(1000);
                string cpStr = QueryPositioner("*OPC?");
                if (Convert.ToInt16(cpStr) == 1)
                    break;
                waitTime++;
                if (waitTime > 30) // timeout at 15 seconds
                    return false;
            }
            return true;
        }

        public override string GetDeviceError()
        {
            string response = QueryPositioner("Err?");
            return response;
        }
        public override void ClearDeviceError()
        {
            WriteToPositioner("!RST");
        }

        #endregion

        #region Private methods

        Device MakeDevice(string addr)
        {
            var props = this.AxisSpecificProperties as ETSPositionerSpecificProperties;
            if (props != null)
            {
                _prefix = "AXIS" + props.AxisNumber() + ":";
            }
            return new Device(string.Empty, "ETS Positioner", addr);
        }

        private void WriteToPositioner(string cmd)
        {
            lock (readWriteLock)
            {
                string response = String.Empty;
                try
                {
                    if (PosConnection != null)
                    {
                        PosConnection.WriteToDevice(_prefix + cmd + "\n");
                    }
                }
                catch (Exception e)
                {
                    string err = string.Format("Error Writing to Positioner: {0}", e);
                    Trace.WriteLine(err);
                    SetErrorMessage(err);
                    throw;
                }
            }

        }

        private string QueryPositioner(string cmd)
        {
            lock (readWriteLock)
            {
                string response = String.Empty;
                try
                {
                    if (PosConnection != null)
                    {
                        PosConnection.WriteToDevice(_prefix + cmd + "\n");
                        Thread.Sleep(100);
                        PosConnection.ReadFromDevice(out response);
                        return response.Trim();
                    }

                    return string.Empty;
                }
                catch (Exception e)
                {
                    string err = string.Format("Error Querying Positioner: {0}", e);
                    Trace.WriteLine(err);
                    SetErrorMessage(err);
                    throw;
                }
            }
        }

        #endregion
    }
}

