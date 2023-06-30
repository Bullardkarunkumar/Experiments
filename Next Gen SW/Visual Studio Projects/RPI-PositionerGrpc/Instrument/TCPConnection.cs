// -----------------------------------------------------------------------
// <copyright file="Connection.cs" company="ETS-Lindgren L.P.">
// Copyright 2013 ETS-Lindgren L.P.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Net.Sockets;

namespace Ets.Instrument
{
    /// <summary>
    /// TCP Connection to a Device at a particular IP address and Port
    /// Reads and Writes over the connection
    /// </summary>
    public class TCPConnection : IConnection
    {
        #region Constants and Fields
        private Device _positioner;
        private TcpClient _tcpClient;
        #endregion

        #region Constructors and Destructors
        public TCPConnection(Device dev)
        {
            Positioner = dev;
         }

        ~TCPConnection()
        {
            if (_tcpClient != null)
                _tcpClient.Close();
        }
        #endregion

        #region Public Properties          
        public Device Positioner
        {
            get { return _positioner; }
            set { _positioner = value; }
        }       
        #endregion      

        #region Public Methods defined by IConnection
        public void SetDevice(Device dev)
        {
            Positioner = dev;
        }
        public bool ConnectToDevice()
        {
            try
            {
                _tcpClient = new TcpClient(Positioner.IPAddress, Positioner.Port);
                _tcpClient.NoDelay = true; // positioner needs each command in a separate packet
                Trace.WriteLine(string.Format("Connected to Device: {0}", Positioner.IPAddress + ":" + Positioner.Port.ToString()));
            }
            catch (SocketException e)
            {
                Trace.WriteLine(string.Format("Socket Exception: {0}",e));
                _tcpClient = null;
            }
            return ((_tcpClient == null)? false:true);
               
        }

        public bool WriteToDevice(string message)
        {
            try
            {
                if (!IsConnected())
                {
                    bool connected = ConnectToDevice();
                    if (!connected)
                        return false;
                }
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message + "\n");

                // Get a client stream for writing. 
                NetworkStream stream = _tcpClient.GetStream();

                //Thread.Sleep(5); // Introduced this delay because the positioner
                        // gets out of sync if it gets commands too fast.
                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                //Trace.WriteLine(string.Format("Sent: {0}", message));
                //stream.Close();
                return true;
            }
            catch (Exception e)
            {
                Trace.WriteLine(string.Format("Exception: {0}", e));
                CloseConnection();
            }
            return false;
         
        }

        public bool ReadFromDevice(out string response)
        {
            // String to store the response ASCII representation.
            string responseData = String.Empty;

            if (!IsConnected())
            {
                response = responseData;
                return false;
            }
            
            try
            {
                // Buffer to store the response bytes.
                Byte[] data = new Byte[256];
               
                // Get a client stream for reading. 
                NetworkStream stream = _tcpClient.GetStream();

                // Read the first batch of the TcpServer response bytes.
                stream.ReadTimeout = 15000; //15 sec timeout
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);              
                //Trace.WriteLine(string.Format("Received: {0}", responseData));
                //stream.Close();
            }
            catch (Exception e)
            {
                Trace.WriteLine(string.Format("Exception: {0}", e));
                CloseConnection();
                response = responseData;
                return false;
            }
            response = responseData;
            return true;
        }

        public bool IsConnected()
        {
            if (_tcpClient == null)
                return false;
            else
                return _tcpClient.Connected;
                
        }

        public void CloseConnection()
        {
            if (_tcpClient != null)
            {
                _tcpClient.Close();
                _tcpClient = null;
                Trace.WriteLine(string.Format("Disconnected from Device: {0}", Positioner.IPAddress + ":" + Positioner.Port.ToString()));
            }
        }
        #endregion

    }


}
