// -----------------------------------------------------------------------
// <copyright file="Device.cs" company="ETS-Lindgren L.P.">
// Copyright 2013 ETS-Lindgren L.P.
// </copyright>
// -----------------------------------------------------------------------


namespace Positioner
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
        #endregion
       
        #region Constructors and Destructors
        public Device()
        {
            Name = "Default Positioner";
            Description = "A Default Positioner";
            IPAddress = "192.168.0.100";
            Port = 1206;
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
