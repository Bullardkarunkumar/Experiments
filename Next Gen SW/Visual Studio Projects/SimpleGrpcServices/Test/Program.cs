// See https://aka.ms/new-console-template for more information



using System.Threading.Tasks;
using Grpc.Net.Client;
using Actions.Iterator;
using Actions.PositionerIterator;
using Actions.MeasureIterator;
using Equipment.Positioner;
using Equipment.NetworkAnalyzer;
using Grpc.Core;

// The port number must match the port of the gRPC server.
//using var channel = GrpcChannel.ForAddress("http://localhost:5150");

//// Positioner equipment test
//var client = new Positioner.PositionerClient(channel);
//var reply = await client.InitializeAsync(
//                  new Equipment.Positioner.InitParams { Id = "1001", Upperlimit = 360.0, Lowerlimit = 0.0 });
//var myId = new Equipment.Positioner.Id { Id_ = "1001" };
//PositionRequest posreq = new PositionRequest { Id = "1001", Position = 120 };
//reply = await client.SeekAsync(posreq);
//var pos = await client.GetCurrentPositionAsync(myId);
//Console.WriteLine("Position: " + pos.Position);

// Network Analyzer equipment test
//var client2 = new NetworkAnalyzer.NetworkAnalyzerClient(channel);
//var reply2 = await client2.InitializeAsync(
//                  new Equipment.NetworkAnalyzer.InitParams { Id = "3001", Frequency = { 1.0, 2.0, 3.0 }, Power = 10.0 });
//var myId2 = new Equipment.NetworkAnalyzer.Id { Id_ = "3001" };
//ReadTraceResponse naresp = await client2.ReadTraceAsync(myId2);
//Console.WriteLine("Trace: " + naresp.Frequency + naresp.Magnitude);

// Measure iterator
using var channel0 = GrpcChannel.ForAddress("http://localhost:5185");
var client0 = new MeasureIterator.MeasureIteratorClient(channel0);
var reply0 = await client0.InitializeAsync(
                  new Actions.MeasureIterator.InitParams { Id = "4001", AnalyzerId = "3001" });

// Positionor iterators
using var channel1 = GrpcChannel.ForAddress("http://localhost:5185");
var client1 = new PositionerIterator.PositionerIteratorClient(channel1);
var reply1 = await client1.InitializeAsync(
                  new Actions.PositionerIterator.InitParams { Id = "2001", Name = "Theta", Start = 0.0, Step = 10.0, Stop = 20.0, PositionerId = "1001", Chid = "2002" });

using var channel3 = GrpcChannel.ForAddress("http://localhost:5185");
var client3 = new PositionerIterator.PositionerIteratorClient(channel3);
var reply3 = await client1.InitializeAsync(
                  new Actions.PositionerIterator.InitParams { Id = "2002", Name = "Phi", Start = 0.0, Step = 20.0, Stop = 40.0, PositionerId = "1002", Chid = "4001" });

// Start test with the top iterator
var myId1 = new Actions.PositionerIterator.Id { Id_ = "2001" };
IteratorLoopRequest loopReq = new IteratorLoopRequest { Id = "2001" };
var measureArray = await client1.DoLoopAsync(loopReq);

//print results
List<Measurement> measurements = new List<Measurement>(measureArray.Measurement);
int count = 0;
foreach (Measurement measurement in measurements)
{
    List<IteratorPathInfo> pairs = new List<IteratorPathInfo>(measurement.Path);
    foreach (IteratorPathInfo pair in pairs) 
        Console.WriteLine(pair.Name + " : " + pair.Value);           
    count++;
    Console.WriteLine();
}
Console.WriteLine("Count : " + count);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
