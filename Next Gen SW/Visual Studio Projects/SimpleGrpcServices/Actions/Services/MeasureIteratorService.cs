using Actions.Iterator;
using Equipment.NetworkAnalyzer;
using Actions.DataStore;
using Grpc.Core;
using Grpc.Net.Client;
using System.Threading.Channels;
using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;

namespace Actions.MeasureIterator.Services
{
    public class MeasureIteratorService : MeasureIterator.MeasureIteratorBase
    {
        private readonly ILogger<MeasureIteratorService> _logger;
        private readonly NetworkAnalyzer.NetworkAnalyzerClient _na_client;
        private readonly DataStore.DataStore.DataStoreClient _ds_client;
       
        static Dictionary<string, MeasureItData> MeasureItDict = new Dictionary<string, MeasureItData>();
        
        public struct MeasureItData
        {
            public MeasureItData(string nam, string an_id)
            {
                name = nam;
                analyzer_id = an_id;
            }
            public string name { get; }
            public string analyzer_id { get; }
            
        }
        public MeasureIteratorService(NetworkAnalyzer.NetworkAnalyzerClient na_client, DataStore.DataStore.DataStoreClient ds_client, ILogger<MeasureIteratorService> logger)
        {
            _logger = logger;
            _na_client= na_client;
            _ds_client= ds_client;
        }

        public override async Task<Reply> Initialize(InitParams prms, ServerCallContext context)
        {            
            var reply = await _na_client.InitializeAsync(
                               new Equipment.NetworkAnalyzer.InitParams { Id = prms.AnalyzerId, Frequency = { 1.0, 2.0, 3.0 }, Power = 10.0 });

            MeasureItData measureItdata = new MeasureItData(prms.Name, prms.AnalyzerId);
            if (MeasureItDict.ContainsKey(prms.Id))
                MeasureItDict[prms.Id] = measureItdata;
            else
            {
                
                MeasureItDict.Add(prms.Id, measureItdata);
            }

            return await Task.FromResult(new Reply
            {
                Message = "ok "
            });
        }

        public override async Task<MeasurementArray> DoLoop( IteratorLoopRequest loopReq,  ServerCallContext context)
        {
            MeasureItData measItdata = MeasureItDict[loopReq.Id];
           
            MeasurementArray measurementArray = new MeasurementArray();
            List<IteratorPathInfo> path = new List<IteratorPathInfo>(loopReq.Path);
            var naId = new Equipment.NetworkAnalyzer.Id { Id_ = measItdata.analyzer_id };
            ReadTraceResponse naresp = await _na_client.ReadTraceAsync(naId);

            //PairDataArray pairDataArray = new PairDataArray();
                                  
            List<IteratorPathInfo> measurement = new List<IteratorPathInfo>();
            for (int i=0; i < naresp.Frequency.Count; i++)
            {
                measurement.AddRange(path);
                measurement.Add(new IteratorPathInfo { Name = "Frequency", Value = naresp.Frequency[i] });
                measurement.Add(new IteratorPathInfo { Name = "Magnitude", Value = naresp.Magnitude[i] });

                // for database storage
                //PairData pairData = new PairData();
                //foreach (IteratorPathInfo pathInfo in path)
                //    pairData.Pair.Add(new Pair { Name = pathInfo.Name, Value = pathInfo.Value });
                //pairData.Pair.Add(new Pair { Name = "Frequency", Value = naresp.Frequency[i] });
                //pairData.Pair.Add(new Pair { Name = "Magnitude", Value = naresp.Magnitude[i] });
                //pairDataArray.PairData.Add(pairData);
            }
            //await _ds_client.SaveTestResultsAsync(pairDataArray);

            Measurement measure = new Measurement();                    
            measure.Path.Add(measurement);                                        
            measurementArray.Measurement.Add(measure);
            foreach (IteratorPathInfo pair in measurement) 
                Console.WriteLine(pair.Name + " : " + pair.Value);
            Console.WriteLine();              
            return measurementArray;

        }

       
    }
}