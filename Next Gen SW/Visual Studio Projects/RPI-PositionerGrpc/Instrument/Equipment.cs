// <copyright file="Equipment.cs" company="ETS-Lindgren L.P."> 
//      Copyright 2011 ETS-Lindgren L.P.
//      File Creation Time: 4/26/2011 12:58:47 PM, by rgretta 
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

using Ets.Common;

namespace Ets.Instrument
{
    /// <summary>
    /// Equipment Interface
    /// </summary>
    public interface IEquipment : ISupportStatus, ISupportDescription, ISupportError
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        ///    <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        bool IsConnected { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is error; otherwise, <c>false</c>.
        /// </value>
        bool IsError { get; set; }

        /// <summary>
        /// Gets or sets the connector.
        /// </summary>
        /// <value>
        /// The connector.
        /// </value>
        IConnector Connector { get; set; }

        bool NeedsReset { get; set; }
        
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        bool Initialize();

        /// <summary>
        /// Uninitializes this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        bool Uninitialize();

        /// <summary>
        /// Connects this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        bool Connect();

        /// <summary>
        /// Connects the specified connector.
        /// </summary>
        /// <param name="connector">The connector.</param>
        /// <returns>true if successful</returns>
        bool Connect(IConnector connector);

        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        bool Disconnect();

        /// <summary>
        /// Resets this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        bool Reset();
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ISupportEquipment
    {
        IEquipment Equipment { get; set; }
    }

    /// <summary>
    /// Equipment class
    /// </summary>
    public class Equipment : IEquipment
    {
        #region Private Fields

        /// <summary>
        /// status field
        /// </summary>
        protected Status _status;
   
        /// <summary>
        /// connector field
        /// </summary>
        IConnector _iconnector;

        /// <summary>
        /// description field
        /// </summary>
        IDescription _description;

        /// <summary>
        /// Error object
        /// </summary>
   //     Error _error = new Error();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        public Equipment()
        {
            _init();
        }

        /// <summary>
        /// _inits this instance.
        /// </summary>
        void _init()
        {
            Description = new Description();
            _status = new Status(this);
            NeedsReset = false;
        }

        #endregion

        #region Events

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the connector.
        /// </summary>
        /// <value>
        /// The connector.
        /// </value>
        virtual public IConnector Connector
        {
            get
            {
                return _iconnector;
            }

            set
            {
                _iconnector = value;
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public IDescription Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public IStatus Status
        {
            get
            {
                return _status;
            }

            set
            {
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is connected.
        /// </summary>
        /// <value>
        ///    <c>true</c> if this instance is connected; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsConnected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is error; otherwise, <c>false</c>.
        /// </value>
        virtual public bool IsError
        {
            get
            {
                return Error.IsError;
            }

            set
            {
                // throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        virtual public IError Error
        {
            get
            {
                return Status.Error;
            }

            set
            {
                ////_error=value;
            }
        }

        virtual public bool NeedsReset { get; set; }

        #endregion

        #region Public Methods
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        virtual public bool Initialize()
        {
            return true;
        }

        /// <summary>
        /// Uninitializes this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        virtual public bool Uninitialize()
        {
            return true;
        }

        /// <summary>
        /// Connects this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        virtual public bool Connect()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Connects the specified connector.
        /// </summary>
        /// <param name="connector">The connector.</param>
        /// <returns>true if successful</returns>
        virtual public bool Connect(IConnector connector)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Disconnects this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        virtual public bool Disconnect()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        /// <returns>true if successful</returns>
        virtual public bool Reset()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Overrides
        #endregion

        #region Internal Methods

        #endregion

        #region Private Methods


        
        #endregion
    }
}
