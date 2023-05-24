// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using PosGrpcService;

// The port number must match the port of the gRPC server.
//using var channel = GrpcChannel.ForAddress("https://localhost:7081");
using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Positioner.PositionerClient(channel);
//var reply = client.GetConfiguration(
//                  new PositionerName { PositionerName_ = " " });
//Console.WriteLine("Configurations: " + reply.ToString());
var posName = new PositionerName { PositionerName_ = "SimPos1" };
var cp = client.CP(posName);
Console.WriteLine("{0}: Current Position is: {1}", "SimPos1", cp.Position_.ToString());

var posRequest = new PositionRequest { Position = 50, PositionerName = "SimPos1" };
client.SK(posRequest);
Console.WriteLine("Seeking position: {0}", posRequest.Position.ToString());

//while (true)
//{
//    Console.WriteLine("Checking Status");
//    var status = client.OPC(posName);
//    if (status.Status_.Equals( true))
//        break;
//    Thread.Sleep(1000);
//}

//var cpNew = client.CP(posName);
//Console.WriteLine("{0}: Current Position is: {1}", "SimPos1", cpNew.Position_.ToString());

Console.WriteLine("Getting Data");

while (true)
{
    var watch = new System.Diagnostics.Stopwatch();
    watch.Start();
    DataResponse dataResponse = client.GetData(new DataRequest());
    watch.Stop();
    Console.WriteLine("Time Elapsed in seconds: {0}", watch.Elapsed.TotalSeconds.ToString());

    Console.WriteLine("Press E to exit, any other key to continue...");
    var key = Console.ReadKey();
    if (key.KeyChar.Equals('e') || key.KeyChar.Equals('E'))
        break;
}
//foreach (var data in dataResponse.Data)
//    Console.WriteLine("{0}", data);


//using var streamingCall = client.GetDataStream(new DataRequest());
//var watch1 = new System.Diagnostics.Stopwatch();
//watch1.Start();
//await foreach (var data in streamingCall.ResponseStream.ReadAllAsync())
//{
//    Console.WriteLine(data);
//    watch1.Stop();
//    Console.WriteLine("Time Elapsed in seconds: {0}", watch1.Elapsed.TotalSeconds.ToString());
//    watch1 = new System.Diagnostics.Stopwatch();
//    watch1.Start();
//}
//watch1.Stop();
//Console.WriteLine("Time Elapsed in seconds: {0}", watch1.Elapsed.TotalSeconds.ToString());

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
