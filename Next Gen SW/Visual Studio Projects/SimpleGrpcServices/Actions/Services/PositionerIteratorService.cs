using Actions.Iterator;
using Equipment.Positioner;
using Actions.MeasureIterator;
using Grpc.Core;
using Grpc.Net.Client;
using System.Threading.Channels;
using System.Collections.Generic;

namespace Actions.PositionerIterator.Services
{
    public class PositionerIteratorService : PositionerIterator.PositionerIteratorBase
    {
        private readonly ILogger<PositionerIteratorService> _logger;
        private  readonly Positioner.PositionerClient _pos_client;
        private readonly PositionerIterator.PositionerIteratorClient _posit_client;
        private readonly Actions.MeasureIterator.MeasureIterator.MeasureIteratorClient _measit_client;
        static Dictionary<string, PosData> PositionersDict = new Dictionary<string, PosData>();
        
        public struct PosData
        {
            public PosData(string nam, double sta, double sto, double ste, double pos, string pos_id, string cid)
            {
                name = nam;
                start = sta;
                stop = sto;
                step = ste;
                position = pos;
                positioner_id= pos_id;
                child_id = cid;

            }
            public string name { get; }
            public double start { get; }
            public double stop { get; }
            public double step { get; }
            public double position { get; set; }
            public string positioner_id { get; set; }
            public string child_id { get; set; }
            public override string ToString() => $"({start},{stop}, {step},{position})";
        }
        public PositionerIteratorService(Positioner.PositionerClient p_client, PositionerIterator.PositionerIteratorClient pi_client, Actions.MeasureIterator.MeasureIterator.MeasureIteratorClient mi_client, ILogger<PositionerIteratorService> logger)
        {
            _logger = logger;
            _pos_client = p_client;
            _posit_client = pi_client;
            _measit_client = mi_client;
           
        }

        public override async Task<Reply> Initialize(InitParams prms, ServerCallContext context)
        {            
            var reply = await _pos_client.InitializeAsync(
                              new Equipment.Positioner.InitParams { Id = prms.PositionerId, Upperlimit = 360.0, Lowerlimit = 0.0 });

            PosData posdata = new PosData(prms.Name, prms.Start, prms.Stop, prms.Step, prms.Start, prms.PositionerId, prms.Chid);
            if (PositionersDict.ContainsKey(prms.Id))
                PositionersDict[prms.Id] = posdata;
            else
            {
                
                PositionersDict.Add(prms.Id, posdata);
            }

            return await Task.FromResult(new Reply
            {
                Message = "ok "
            });
        }

        public override async Task<MeasurementArray> DoLoop( IteratorLoopRequest loopReq,  ServerCallContext context)
        {
            PosData posdata = PositionersDict[loopReq.Id];          
            var myId = new Equipment.Positioner.Id { Id_ = posdata.positioner_id };

            //Metadata.Entry? metadataEntry = context.RequestHeaders.FirstOrDefault(m =>
            //String.Equals(m.Key, "name", StringComparison.Ordinal));
            MeasurementArray measurementArray = new MeasurementArray();
            
            while (posdata.position <= posdata.stop)
            {
                PositionRequest posreq = new PositionRequest { Id = posdata.positioner_id, Position = posdata.position };
                var reply = await _pos_client.SeekAsync(posreq);
                var pos = await _pos_client.GetCurrentPositionAsync(myId);
               
                //Metadata metadata = new Metadata();
                //foreach (var header in context.RequestHeaders)
                //    metadata.Add(header);
                //metadata.Add("Position-" + posdata.positioner_id, pos.Position.ToString());
             
                List< IteratorPathInfo> path = new List<IteratorPathInfo>(loopReq.Path);
                path.Add(new IteratorPathInfo{ Name = posdata.name, Value = posdata.position });
                IteratorLoopRequest nextLoopReq = new IteratorLoopRequest();
                nextLoopReq.Id = posdata.child_id;
                nextLoopReq.Path.AddRange(path);

                posdata.position = posdata.position + posdata.step;

                
                if (posdata.child_id.Length > 0)
                {                    
                   
                    MeasurementArray measurementArray1= new MeasurementArray();
                    if (posdata.child_id[0] == '4')
                    {
                       
                        measurementArray1 = await _measit_client.DoLoopAsync(nextLoopReq);
                    }
                    else
                        measurementArray1 = await _posit_client.DoLoopAsync(nextLoopReq);
                    measurementArray.Measurement.AddRange(measurementArray1.Measurement);
                }
       
            }
            posdata.position = posdata.start;
            PositionersDict[loopReq.Id] = posdata;
            
            return measurementArray;

        }

        public override async Task<PositionResponse> GetCurrentPosition(Id id, ServerCallContext context)
        {
            PosData posdata = PositionersDict[id.Id_];            
            var myId = new Equipment.Positioner.Id { Id_ = posdata.positioner_id };
            var pos = await _pos_client.GetCurrentPositionAsync(myId);
            posdata.position = pos.Position;
            PositionersDict[id.Id_] = posdata;
            return await Task.FromResult(new PositionResponse
            {
                Position = posdata.position
            }) ;
        }
    }
}