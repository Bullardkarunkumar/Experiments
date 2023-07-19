using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using System.Net.Sockets;
using VisaGrpcService;

namespace GrpcSwitchClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //			using (var channel = GrpcChannel.ForAddress("https://localhost:15003"))
            try
            {
                string tok;
                Channel channel = new Channel("127.0.0.1:15003", ChannelCredentials.Insecure);
                var client = new VisaConnect.VisaConnectClient(channel);
                var sv = new StringValue();
                sv.Value = "TCPIP0::127.0.0.1::6385::SOCKET";  // 6380, 6385 - 6389 is Erics simulator
                var reply = client.Open(sv);
                if (reply.Succeded)
                {
                    tok = reply.Message;

                }
                else
                {
                    Console.WriteLine(reply.Message);
                    return;
                }
                var wts = new WriteToSession();
                wts.Command = "SK 100";
                wts.SessionToken = tok;
                if (!client.Write(wts).Succeded)
                {
                    Console.WriteLine(reply.Message);
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
