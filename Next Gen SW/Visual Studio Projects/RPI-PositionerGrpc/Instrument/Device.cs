// -----------------------------------------------------------------------
// <copyright file="Device.cs" company="ETS-Lindgren L.P.">
// Copyright 2013 ETS-Lindgren L.P.
// </copyright>
// -----------------------------------------------------------------------


namespace Ets.Instrument
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Device that is specified by an IP address and a port
    /// </summary>
    public class Device
    {
        #region Constants and Fields
        private String _name;
        private String _description;
        private String _ipaddress;
        private UInt16 _port;
        private String _visaConnectString;
        #endregion

        #region Constructors and Destructors
        public Device()
        {
            Name = "Default Positioner";
            Description = "A Default Positioner";
            IPAddress = "192.168.0.100";
            Port = 1206;
            _visaConnectString = string.Empty;
        }

        public Device(String name, String desc, String ipaddr, UInt16 port)
        {
            Name = name;
            Description = desc;
            IPAddress = ipaddr;
            Port = port;
        }

        public Device(Device device)
        {
            this.Name = device.Name;
            this.Description = device.Description;
            this.IPAddress = device.IPAddress;
            this.Port = device.Port;
        }

        public Device(String name, String desc, String visaConnectString)
        {
            Name = name;
            Description = desc;
            IPAddress = string.Empty;
            Port = 0;
            _visaConnectString = visaConnectString;
        }

        #endregion

        #region Public Properties
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public String IPAddress
        {
            get { return _ipaddress; }
            set { _ipaddress = value; }
        }
        public UInt16 Port
        {
            get { return _port; }
            set { _port = value; }
        }

        public String VisaConnectString
        {
            get { return _visaConnectString; }
            set { _visaConnectString = value; }
        }
        #endregion

        #region Overrides
        public override string ToString()
        {
            //return base.ToString();
            return  IPAddress + ":" + Port + " - " + Description;
        }
        #endregion
    }

}
