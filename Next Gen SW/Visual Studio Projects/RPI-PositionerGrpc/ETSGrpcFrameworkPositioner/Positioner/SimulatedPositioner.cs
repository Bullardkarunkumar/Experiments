using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ets.Instrument;
using System.Threading;
using System.Diagnostics;

using System.ComponentModel.Composition;
using System.Timers;
using ETSGrpcPositioner.Positioner;

namespace ETSGrpcPositioner.Positioner
{

    /// <summary>
    /// Implementation of the Simulated Positioner
    /// </summary>
    ///
    public class SimulatedPositioner : Axis
    {        
        
        #region Constructors

        /// <summary>
        /// Default constructor needed for dependency injection
        /// </summary>
        public SimulatedPositioner()
        {
            this.AxisSpecificProperties = new ETSPositionerSpecificProperties();
        }

        #endregion

        #region Public Overriden Properties of Axis

        public override string GetIDN()
        {
            return "ETS-Lindgren Inc. Simulated Positioner";
        }

        public override AxisRotation RotationMode
        {
            get
            {
                return _rotationMode;
            }
            set
            {
                _rotationMode = value;
            }
        }

        public override double CurrentPosition
        {
            get
            {
                return _currentPosition;
            }

            set
            {
                _currentPosition = value;
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
                return _cwOrUpperLimit;
            }
            set
            {
                _cwOrUpperLimit = value;
            }
        }

        public override double CcwLimit
        {
            get
            {
                return _ccwOrLowerLimit;
            }
            set
            {
                _ccwOrLowerLimit = value;
            }
        }

        public override double AccelerationInMS
        {
            get
            {
                return _acceleration;
            }
            set
            {
                _acceleration = value;
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
                }
            }

        }

        public override double CurrentVelocity
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
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

                return (int)_currentDirection;
            }
        }

        public override bool IsHomed
        {
            get
            {
                return true;
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

        #region Private properties specific to Simulated Positioner

        private double[] _speedSettingsDegreesPerSec = new double[8];
        private Object readWriteLock = new Object();

        private double _minSpeed;
        private System.Timers.Timer moveTimer;
        private double _distanceMoved;
        private double _distanceToMove;
        private double _distPerTime;
        private bool _moveToTarget;

        private MotionDir _currentDirection; //up/cw or down/ccw or stopped


        #endregion

        #region Overriden methods of Axis

        public override void SetDevice(string addr)
        {

        }

        public override bool InitDeviceSpecific()
        {

            _maxSpeed = 60;  // degrees per second   
            _minSpeed = 0;

            // Create a periodic timer with a 100 ms interval to simulate movement at a particular speed
            moveTimer = new System.Timers.Timer(100);
            // Hook up the Elapsed event for the timer. 
            moveTimer.Elapsed += OnTimedEvent;
            moveTimer.AutoReset = true;
            moveTimer.Enabled = false;

            this.Name = "Simulated Positioner";

            return true;
        }
        #endregion

        #region private methods

        /// <summary>
        /// Creates the expected connection
        /// </summary>
        /// <param name="dev">the device</param>
        /// <returns>the connection</returns>
        public override IConnection CreateConnection(Device dev)
        {
            return PosConnection = new SimulatedConnection();
        }

        // every 100 ms
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //Debug.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);            
            if (_currentDirection == MotionDir.CWorUp)
            {
                _currentPosition += _distPerTime;
            }
            else
            {
                _currentPosition -= _distPerTime;
            }

            if (RotationMode == AxisRotation.Continuous)
            {
                _currentPosition = _currentPosition % 360.0;
                if (_currentPosition < 0)
                    _currentPosition = 360 + _currentPosition;
            }

            _distanceMoved += _distPerTime;

            if (_moveToTarget && (_distanceMoved >= _distanceToMove))
            {
                _currentPosition = _targetPosition;
                moveTimer.Enabled = false;
                _currentDirection = MotionDir.Stopped;
                Debug.WriteLine("Motion Stopped");
            }

        }

        private void StartMoving()
        {
            _distanceMoved = 0.0;
            _distPerTime = _speedSettingsDegreesPerSec[_currentSpeedIndex] / 10.0; // distance in 100 ms            
            moveTimer.Enabled = true;
            Debug.WriteLine("Motion Started ");
        }

        public override string Seek(double position)
        {
            if (_currentDirection != MotionDir.Stopped)
                Stop();

            _targetPosition = Convert.ToDouble(position);
            if (RotationMode == AxisRotation.Continuous)
            {
                _currentPosition = _currentPosition % 360;
                if (_currentPosition < 0)
                    _currentPosition = 360 + _currentPosition;

                _targetPosition = _targetPosition % 360.0;
                if (_targetPosition < 0)
                    _targetPosition = 360 + _targetPosition;
            }
            else
            {
                if ((_targetPosition > _cwOrUpperLimit) || (_targetPosition < _ccwOrLowerLimit))
                    return "ERROR:Seek position is beyond the limits";
            }

            if (_targetPosition == _currentPosition)
                return "ERROR:Already at target position";


            _distanceToMove = Math.Abs(_targetPosition - _currentPosition);

            if (_targetPosition > _currentPosition)
                _currentDirection = MotionDir.CWorUp;
            else
                _currentDirection = MotionDir.CCWorDown;

            // take the shortest path in Continuous rotation mode
            if (RotationMode == AxisRotation.Continuous)
            {
                if (_distanceToMove > 180.0)
                {
                    _distanceToMove = 360 - _distanceToMove;
                    // change direction
                    if (_targetPosition < _currentPosition)
                        _currentDirection = MotionDir.CWorUp;
                    else
                        _currentDirection = MotionDir.CCWorDown;
                }
            }
            _moveToTarget = true;
            StartMoving();

            return "OK";
        }

        public override string SeekPositive(double position)
        {
            _targetPosition = Convert.ToDouble(position);
            if (RotationMode == AxisRotation.Continuous)
            {
                _currentPosition = _currentPosition % 360;
                if (_currentPosition < 0)
                    _currentPosition = 360 + _currentPosition;
                _targetPosition = _targetPosition % 360.0;
                if (_targetPosition < 0)
                    _targetPosition = 360 + _targetPosition;
                _distanceToMove = Math.Abs(_targetPosition - _currentPosition);
                if (_targetPosition < _currentPosition)
                    _distanceToMove = 360 - _distanceToMove;

            }
            else
            {
                if ((_targetPosition < _currentPosition) || (_targetPosition > _cwOrUpperLimit))
                    return "ERROR:Seek position is beyond the limits";
                _distanceToMove = Math.Abs(_targetPosition - _currentPosition);
            }

            _currentDirection = MotionDir.CWorUp;
            _moveToTarget = true;
            StartMoving();

            return "OK";
        }

        public override string SeekNegative(double position)
        {
            _targetPosition = Convert.ToDouble(position);
            if (RotationMode == AxisRotation.Continuous)
            {
                _currentPosition = _currentPosition % 360;
                if (_currentPosition < 0)
                    _currentPosition = 360 + _currentPosition;
                _targetPosition = _targetPosition % 360.0;
                if (_targetPosition < 0)
                    _targetPosition = 360 + _targetPosition;
                _distanceToMove = Math.Abs(_targetPosition - _currentPosition);
                if (_targetPosition > _currentPosition)
                    _distanceToMove = 360 - _distanceToMove;
            }
            else
            {
                if ((_targetPosition > _currentPosition) || (_targetPosition < _ccwOrLowerLimit))
                    return "ERROR:Seek position is beyond the limits";
                _distanceToMove = Math.Abs(_targetPosition - _currentPosition);
            }
            _currentDirection = MotionDir.CCWorDown;
            _moveToTarget = true;
            StartMoving();

            return "OK";
        }

        public override string Clockwise()
        {
            if (RotationMode == AxisRotation.Continuous)
            {
                _currentDirection = MotionDir.CWorUp;
                _moveToTarget = false;
                StartMoving();
            }
            else
            {
                Seek(_cwOrUpperLimit);
            }

            return "OK";
        }

        public override string CounterClockwise()
        {
            if (RotationMode == AxisRotation.Continuous)
            {
                _currentDirection = MotionDir.CCWorDown;
                _moveToTarget = false;
                StartMoving();
            }
            else
            {
                Seek(_ccwOrLowerLimit);
            }
            return "OK";
        }

        public override string Stop()
        {
            moveTimer.Enabled = false;
            _currentDirection = MotionDir.Stopped;
            return "OK";
        }

        public override void SetSpeedSettingPercent(int setting, double val)
        {

            base.SetSpeedSettingPercent(setting, val);
            _speedSettingsDegreesPerSec[setting - 1] = _minSpeed + ((_maxSpeed - _minSpeed) * val / 100.0);

            if (_currentSpeedIndex == (setting - 1))
                CurrentSpeed = setting; // reset current speed since the setting % value has changed
        }

        public override string Scan()
        {
            return "OK";
        }

        public override bool Home()
        {
            return true;
        }

        public override string GetDeviceError()
        {
            string response = "0";
            return response;
        }
        public override void ClearDeviceError()
        {

        }

        #endregion
    }
}
