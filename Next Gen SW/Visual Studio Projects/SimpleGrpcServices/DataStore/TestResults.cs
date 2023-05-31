namespace Actions.DataStore
{
    using MongoDB.Driver;
    using MongoDB.Bson;
    
    public class TestResults
    {
        static IMongoDatabase database;
        static MongoClient client;
        static ObjectId testId;
        static string jobNumber;

        //string atlasUri = "mongodb+srv://user:password@cluster0.qmhofyk.mongodb.net/?retryWrites=true&w=majority";
        public bool ConnectToDB()
        {
            //client = new MongoClient(atlasUri);
            //database = client.GetDatabase("ets_tests");
            return true;
        }
        public bool AddTest(string jobNum)
        {
            var testCollection = database.GetCollection<Test>("tests");
            jobNumber = jobNum;
            var results = testCollection.Find(x => x.jobNumber == jobNum).ToList();
            if (results.Count == 0)
                testId = AddTest(database);
            else
                testId = results[0].Id;
            return true;
        }
        public bool SaveTestResults(List<DataItem> dataItems)
        {
            var dataCollection = database.GetCollection<Data>("data");
            var results = dataCollection.Find(x => x.testID == testId).ToList();
            List <DataItem> testDataItems = new List<DataItem>();
           
            if (results.Count > 0)
            {
                testDataItems.AddRange(results[0].data);
                foreach (DataItem dataItem in dataItems)
                    testDataItems.Add(dataItem);
                
                var filter = Builders<Data>.Filter.Eq("testID", testId);
                var update = Builders<Data>.Update.Set("data", testDataItems);
                dataCollection.UpdateOne(filter, update);
                
            }
            else
            {
                Data testData = new Data();
                testData.testID = testId ;
                foreach (DataItem dataItem in dataItems)
                    testData.data.Add(dataItem);
                dataCollection.InsertOne(testData);
            }
            return true;
        }

        private ObjectId AddTest(IMongoDatabase database)
        {
            Test test = new Test();
            test.name = "Response Measurement";
            test.jobNumber = jobNumber;
            test.dutSerialNumber = "A001";
            test.date = DateTime.Now;

            Positioner positioner = new("EMControl", "192.168.0.100", 360, 0, 12.5);
            NetworkAnalyzer na = new NetworkAnalyzer("R&S ZNB Series", "192.168.0.200", -80, 1000);
            test.instruments = new List<Instrument>();
            test.instruments.Add(positioner);
            test.instruments.Add(na);

            // Insert the 'test' into the database
            var collection = database.GetCollection<Test>("tests");
            collection.InsertOne(test);
            return test.Id;
        }

    }
}