using Grpc.Core;
using PosGrpcService;
using Positioner;

namespace PosGrpcService.Services
{
    public class PositionerService : Positioner.PositionerBase
    {
        Dictionary<string, Axis> PositionersDict = new Dictionary<string, Axis>();
        private readonly ILogger<PositionerService> _logger;
        List<Configuration> allConfigurations = new List<Configuration>
        {
            new Configuration{ PositionerName = "SimPos1", PositionerType = "Simulated Positioner", UpperLimit = 360.0 , LowerLimit= 0.0 },
            new Configuration{ PositionerName = "SimPos2", PositionerType = "Simulated Positioner", UpperLimit = 360.0 , LowerLimit= 0.0 },
        };
        static int dataSize = 500000;
        double[] Data = new double[dataSize];
        public PositionerService(ILogger<PositionerService> logger)
        {
            _logger = logger;

            foreach (var config in allConfigurations)
            {
                Axis ax = new SimulatedPositioner();
                ax.Name = config.PositionerName;
                ax.LowerLimit = (double)config.LowerLimit;
                ax.UpperLimit = (double)config.UpperLimit;
                PositionersDict.Add(ax.Name, ax);
                ax.ConnectToDevice("");
            }
            for( int i = 0; i < dataSize; i++)
            {
                Data[i] = i * 1.0;
            }
        }

        // Server side handler of the GetConfiguration RPC
        public override Task<Configurations> GetConfiguration(PositionerName request, ServerCallContext context)
        {
            //return base.GetConfiguration(request, context);
            
            Configurations allConfigs = new Configurations();
            
            allConfigs.Configurations_.Add(allConfigurations);
            return Task.FromResult(allConfigs);
        }

        public override Task<Position> CP(PositionerName request, ServerCallContext context)
        {
            //return base.CP(request, context);
            Axis ax = PositionersDict[request.PositionerName_];
            Position position = new Position();
            position.Position_ = ax.CurrentPosition;
            return Task.FromResult<Position>(position); 
        }

        public override Task<Status> OPC(PositionerName request, ServerCallContext context)
        {
            //return base.OPC(request, context); 
            Axis ax = PositionersDict[request.PositionerName_];
            Status status = new Status();
            status.Status_ = ax.OperationComplete;
            return Task.FromResult<Status>(status);
        }

        public override Task<CommandResponse> SK(PositionRequest request, ServerCallContext context)
        {
            //return base.SK(request, context);
            Axis ax = PositionersDict[request.PositionerName];
            ax.Seek(request.Position);
            CommandResponse commandResponse = new CommandResponse();
            return Task.FromResult<CommandResponse>(commandResponse);
        }

        public override Task<DataResponse> GetData(DataRequest request, ServerCallContext context)
        {
            //return base.GetData(request, context);
            DataResponse data = new DataResponse();
            data.Data.Add(Data);            
            return Task.FromResult<DataResponse>(data);
        }

        public override async Task GetDataStream(DataRequest request, IServerStreamWriter<DataResponse> responseStream, ServerCallContext context)
        {
            //return base.GetDataStream(request, responseStream, context);
            DataResponse data = new DataResponse();
            data.Data.Add(Data);
            for (int i = 0; i < 1; i++)
            { 
                await responseStream.WriteAsync(data);
                //Thread.Sleep(1000);
            }
        }
    }
}