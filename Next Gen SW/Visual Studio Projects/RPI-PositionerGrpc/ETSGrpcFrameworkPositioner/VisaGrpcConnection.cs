using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace Ets.Instrument
{
    /// <summary>
    /// TCP Connection to a Device at a particular IP address and Port
    /// Reads and Writes over the connection
    /// </summary>
    public class VisaGrpcConnection : IConnection
    {
        #region Constants and Fields
        private Device _positioner;
        private PosGrpcService.Positioner.PositionerClient grpcClient;
        #endregion

        #region Constructors and Destructors
        public VisaGrpcConnection(Device dev)
        {
            Positioner = dev;
            grpcClient = null;
        }

        ~VisaGrpcConnection()
        {
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
                Channel channel = new Channel("127.0.0.1:30051", ChannelCredentials.Insecure);
                //var channel = GrpcChannel.ForAddress("https://localhost:7081", new GrpcChannelOptions
                //{
                //    HttpHandler = new WinHttpHandler()
                //});

                grpcClient = new PosGrpcService.Positioner.PositionerClient(channel);
                Trace.WriteLine(string.Format("Connected to Device: {0}", Positioner.IPAddress + ":" + Positioner.Port.ToString()));
            }
            catch (Exception e)
            {
                Trace.WriteLine(string.Format("GRPC Exception: {0}", e));
                grpcClient = null;
            }
            return ((grpcClient == null) ? false : true);

        }

        /// <summary>
        /// Not used in GRPC connections
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool WriteToDevice(string message)
        {
            return false;
        }

        /// <summary>
        /// Not used in GRPC
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public bool ReadFromDevice(out string response)
        {
            response = null;
            return false;
        }

        public bool IsConnected()
        {
            if (grpcClient == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Does nothing for GRPC
        /// </summary>
        public void CloseConnection()
        {
        }

        public PosGrpcService.Positioner.PositionerClient GrpcClient
        {
            get { return grpcClient; }
        }

        #endregion

    }
}
