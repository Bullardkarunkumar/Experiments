using Equipment.NetworkAnalyzer;
using Grpc.Core;

namespace Equipment.NetworkAnalyzer.Services
{
    public class NetworkAnalyzerService : NetworkAnalyzer.NetworkAnalyzerBase
    {
        private readonly ILogger<NetworkAnalyzerService> _logger;
        static Dictionary<string, NAData> NADict = new Dictionary<string, NAData>();

        public struct NAData
        {
            public NAData(double pow, double[] freq)
            {
                power = pow;
                frequency.AddRange(freq);
            }

            public List<double> frequency = new List<double>();
            public double  power { get; }           
            public override string ToString() => $"({power},{frequency})";
        }
        public NetworkAnalyzerService(ILogger<NetworkAnalyzerService> logger)
        {
            _logger = logger;
        }

        public override Task<Reply> Initialize(InitParams prms, ServerCallContext context)
        {
           
            NAData nadata = new NAData( prms.Power, prms.Frequency.ToArray() );
            if (NADict.ContainsKey(prms.Id))
                NADict[prms.Id] = nadata;
            else
                NADict.Add(prms.Id, nadata);
            return Task.FromResult(new Reply
            {
                Message = "OK"
            });
        }

       
        public override Task<ReadTraceResponse> ReadTrace(Id id, ServerCallContext context)
        {
            double[] magnitude = new double[NADict[id.Id_].frequency.Count];
            for (int i = 0; i < magnitude.Count(); i++ )
                magnitude[i] = NADict[id.Id_].frequency[i] + NADict[id.Id_].power;
            
            ReadTraceResponse data = new ReadTraceResponse();
            data.Magnitude.AddRange(magnitude);
            data.Frequency.AddRange(NADict[id.Id_].frequency);
            return Task.FromResult(data);
        }
    }
}