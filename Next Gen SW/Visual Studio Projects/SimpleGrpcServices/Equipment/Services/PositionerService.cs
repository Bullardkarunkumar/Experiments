using Equipment.Positioner;
using Grpc.Core;

namespace Equipment.Positioner.Services
{
    public class PositionerService : Positioner.PositionerBase
    {
        private readonly ILogger<PositionerService> _logger;
        static Dictionary<string, PosData> PositionersDict = new Dictionary<string, PosData>();

        public struct PosData
        {
            public PosData(double ul, double ll, double pos)
            {
                upperlimit = ul;
                lowerlimit = ll;            
                position = pos;
            }

            public double upperlimit { get; }
            public double lowerlimit { get; }
            public double position { get; set; }

            public override string ToString() => $"({upperlimit},{lowerlimit}, {position})";
        }
        public PositionerService(ILogger<PositionerService> logger)
        {
            _logger = logger;
        }

        public override Task<Reply> Initialize(InitParams prms, ServerCallContext context)
        {
           
            PosData posdata = new PosData( prms.Upperlimit, prms.Lowerlimit, prms.Lowerlimit);
            if (PositionersDict.ContainsKey(prms.Id))
                PositionersDict[prms.Id] = posdata;
            else
                PositionersDict.Add(prms.Id, posdata);
            return Task.FromResult(new Reply
            {
                Message = "OK"
            });
        }

        public override Task<Reply> Seek (PositionRequest posreq, ServerCallContext context)
        {
            PosData posdata = PositionersDict[posreq.Id];
            if (posreq.Position < posdata.lowerlimit)
                posdata.position = posdata.lowerlimit;
            else if (posreq.Position > posdata.upperlimit)
                posdata.position = posdata.lowerlimit;
            else
                posdata.position = posreq.Position;
            PositionersDict[posreq.Id] = posdata;
            return Task.FromResult(new Reply
            {
                Message = "OK"
            });
        }
        public override Task<PositionResponse> GetCurrentPosition(Id id, ServerCallContext context)
        {
            return Task.FromResult(new PositionResponse
            {
                Position = PositionersDict[id.Id_].position
            });
        }
    }
}