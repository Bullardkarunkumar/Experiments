using Actions.DataStore;
using Grpc.Core;
using Grpc.Net.Client;
using System.Threading.Channels;
using System.Collections.Generic;

namespace Actions.DataStore.Services
{
    public class DataStoreService : DataStore.DataStoreBase
    {
        private readonly ILogger<DataStoreService> _logger;
                            
        public DataStoreService( ILogger<DataStoreService> logger)
        {
            _logger = logger;
           
        }
        
        public override async Task<Reply> SaveTestResults(PairDataArray pairDataArray,  ServerCallContext context)
        {

            TestResults results  = new TestResults();
            results.ConnectToDB();
            results.AddTest("DemoJob");
            List<DataItem> dataItems = new List<DataItem>();
            
            foreach (var pairData in pairDataArray.PairData)
            {
                DataItem dataItem = new DataItem();
                foreach (var pair in pairData.Pair)
                {
                    switch (pair.Name)
                    {
                       case "Phi" : 
                            dataItem.phi = pair.Value;
                            break;
                       case "Theta":
                            dataItem.theta = pair.Value;
                            break;
                        case "Frequency":
                            dataItem.frequency = pair.Value;
                            break;
                        case "Magnitude":
                            dataItem.value1 = pair.Value;
                            break;

                    }
                }
                dataItems.Add(dataItem);
                
            }
            results.SaveTestResults(dataItems);

            return await Task.FromResult(new Reply
            {
                Message = "ok "
            });

        }

       
    }
}