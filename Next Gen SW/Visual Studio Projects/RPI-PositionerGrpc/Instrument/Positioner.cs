using System;
using System.Collections.Generic;

namespace Ets.Instrument
{

    public interface IPositioner
    {
        void MoveTo(double position);
        void MoveToHome();
        bool MoveToHomeSpecific();
        void MoveUp();
        void MoveDown();
        void MoveClockwise();
        void MoveCounterClockwise();
        void MoveStop();
        void MoveScan();

        void EnableLimits(bool tf);

        List<double> VelocityPercentages { get; set; }
        double VelocityPercentage { get; set; }
        int VelocityIndex { get; set; }
        double Velocity { get; set; }
        double MaxVelocity { get; set; }
        double CurrentPosition { get; set; }
        double CurrentVelocity { get; set; }

        bool IsInPosition {get;  set;  }
        bool IsMoving { get; set; }
        bool IsMovingCW { get; set; }
        bool IsHomed { get; set; }

        double RampTime { get; set; }
        double SuggestedUpperLimit { get; set; }
        double SuggestedLowerLimit { get; set; }
        double UpperLimit { get; set; }
        double LowerLimit { get; set; }
        double PositionOffset { get; set; }

        double ScanCycle { get; set; }
    }

    public class Positioner : Equipment, IPositioner
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Positioner"/> class.
        /// </summary>
        public Positioner()
        {
            _init();
        }

        /// <summary>
        /// _inits this instance.
        /// </summary>
        void _init()
        {
            Velocity = 0;
            MaxVelocity = 100;
            CurrentVelocity = 0;

            UpperLimit = 0;
            LowerLimit = 0;
            ScanCycle = 0;

            IsHomed = false;
            IsMoving = false;
            IsMovingCW = false;
            IsInPosition = false;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Enables the limits.
        /// </summary>
        /// <param name="tf">if set to <c>true</c> [tf].</param>
        public virtual void EnableLimits(bool tf)
        {

        }

        /// <summary>
        /// Moves to.
        /// </summary>
        /// <param name="position">The position.</param>
        virtual public void MoveTo(double position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves to home.
        /// </summary>
        virtual public void MoveToHome()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves to home specific.
        /// </summary>
        /// <returns></returns>
        virtual public bool MoveToHomeSpecific()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves up.
        /// </summary>
        virtual public void MoveUp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves down.
        /// </summary>
        virtual public void MoveDown()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the clockwise.
        /// </summary>
        virtual public void MoveClockwise()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the counter clockwise.
        /// </summary>
        virtual public void MoveCounterClockwise()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the stop.
        /// </summary>
        virtual public void MoveStop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Moves the scan.
        /// </summary>
        virtual public void MoveScan()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Properties

        double _currentVelocity;
        /// <summary>
        /// Gets or sets the current velocity.
        /// </summary>
        /// <value>
        /// The current velocity.
        /// </value>
        public virtual double CurrentVelocity
        {
            get
            {
                return _currentVelocity;
            }
            set
            {
                _currentVelocity = value;
            }
        }

        double _velocity = 0;
        /// <summary>
        /// Gets or sets the velocity.
        /// </summary>
        /// <value>
        /// The velocity.
        /// </value>
        public virtual double Velocity
        {
            get
            {
                return _velocity;
            }

            set
            {
                _velocity = value;
            }
        }

        double _maxVelocity = 0;
        /// <summary>
        /// Gets or sets the max velocity.
        /// </summary>
        /// <value>
        /// The max velocity.
        /// </value>
        virtual public double MaxVelocity
        {
            get
            {
                return _maxVelocity;
            }
            set
            {
                _maxVelocity = value;
            }
        }

        double _suggestedUpperLimit = 0;
        /// <summary>
        /// Gets or sets the suggested upper limit.
        /// </summary>
        /// <value>
        /// The suggested upper limit.
        /// </value>
        virtual public double SuggestedUpperLimit
        {
            get
            {
                return _suggestedUpperLimit;
            }
            set
            {
                _suggestedUpperLimit = value;
            }

        }

        double _suggestedLowerLimit = 0;
        /// <summary>
        /// Gets or sets the suggested lower limit.
        /// </summary>
        /// <value>
        /// The suggested lower limit.
        /// </value>
        virtual public double SuggestedLowerLimit 
        { 
            get
            {
                return _suggestedLowerLimit;
            }
            set
            {
                _suggestedLowerLimit = value;
            }
                 
        }

        double _upperLimit = 0;
        /// <summary>
        /// Gets or sets the upper limit.
        /// </summary>
        /// <value>
        /// The upper limit.
        /// </value>
        virtual public double UpperLimit
        {
            get
            {
                return _upperLimit;
            }
            set
            {
                _upperLimit = value;
            }
        }

        double _lowerLimit = 0;
        /// <summary>
        /// Gets or sets the lower limit.
        /// </summary>
        /// <value>
        /// The lower limit.
        /// </value>
        virtual public double LowerLimit
        {
            get
            {
                return _lowerLimit;
            }
            set
            {
                _lowerLimit = value;
            }
        }

        double _positionOffset=0;
        /// <summary>
        /// Gets or sets the position offset.
        /// </summary>
        /// <value>
        /// The position offset.
        /// </value>
        virtual public double PositionOffset
        {
            get
            {
                return _positionOffset;
            }

            set
            {
                _positionOffset = value;
            }
        }

        /// <summary>
        /// Gets or sets the ramp time.
        /// </summary>
        /// <value>
        /// The ramp time.
        /// </value>
        virtual public double RampTime { get; set; }

        /// <summary>
        /// Gets or sets the velocity percentage.
        /// </summary>
        /// <value>
        /// The velocity percentage.
        /// </value>
        virtual public double VelocityPercentage { get; set; }

        /// <summary>
        /// Gets or sets the index of the velocity.
        /// </summary>
        /// <value>
        /// The index of the velocity.
        /// </value>
        virtual public int VelocityIndex { get; set; }

        /// <summary>
        /// Gets or sets the current position.
        /// </summary>
        /// <value>
        /// The current position.
        /// </value>
        virtual public double CurrentPosition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is in position.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is in position; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsInPosition { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is moving.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is moving; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsMoving { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is moving CW.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is moving CW; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsMovingCW { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is homed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is homed; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsHomed { get; set; }

        double _scanCycle = 0;
        /// <summary>
        /// Gets or sets the scan cycle.
        /// </summary>
        /// <value>
        /// The scan cycle.
        /// </value>
        public double ScanCycle
        {
            get
            {
                return _scanCycle;
            }
            set
            {
                _scanCycle=value;
            }
        }

        /// <summary>
        /// Gets the velocity percentages.
        /// </summary>
        virtual public List<double> VelocityPercentages
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        #endregion

    }
}
