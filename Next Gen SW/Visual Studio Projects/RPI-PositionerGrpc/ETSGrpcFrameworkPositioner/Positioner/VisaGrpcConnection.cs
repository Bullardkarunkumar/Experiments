using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using VisaGrpcService;

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
        private VisaConnect.VisaConnectClient grpcClient;
        private string sessionToken;
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
                Channel channel = new Channel("127.0.0.1:15003", ChannelCredentials.Insecure);
                grpcClient = new VisaConnect.VisaConnectClient(channel);
                var sv = new StringValue();
                sv.Value = Positioner.VisaConnectString;
                var reply = grpcClient.Open(sv);
                if (reply.Succeded) 
                { 
                    Trace.WriteLine(string.Format("Connected to VISA gRPC: {0}", Positioner.VisaConnectString));
                    sessionToken = reply.Message;
                }
                else
                {
                    Trace.WriteLine(string.Format("Connection failed to VISA gRPC: {0}", Positioner.VisaConnectString));
                    grpcClient = null;
                }
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
            if (grpcClient != null)
            {
                try
                {
                    var wts = new WriteToSession();
                    wts.Command = message;
                    wts.SessionToken = sessionToken;
                    VisaResponse response;
                    response = grpcClient.Write(wts);
                    if (!response.Succeded)
                    {
                        Trace.WriteLine(response.Message);
                        return false;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                    return false;
                }
            }

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

            if (grpcClient != null)
            {
                try
                {
                    var rfs = new ReadFromSession();
                    rfs.SessionToken = sessionToken;
                    VisaResponse res;
                    res = grpcClient.Read(rfs);
                    if (!res.Succeded)
                    {
                        Trace.WriteLine(res.Message);
                        return false;
                    }

                    response = res.Message;

                    return true;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                    return false;
                }
            }


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
            if (grpcClient != null)
            {
                StringValue stringValue = new StringValue();
                stringValue.Value = sessionToken;
                grpcClient.Close(stringValue);
                grpcClient = null;
            }
        }

        #endregion

    }
}
