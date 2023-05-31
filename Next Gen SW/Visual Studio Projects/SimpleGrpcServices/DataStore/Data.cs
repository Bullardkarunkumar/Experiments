using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions.DataStore
{
    internal class Data
    {
        public ObjectId Id { get; set; }
        public ObjectId  testID { get; set; }
        public List<DataItem> data = new List<DataItem>();
    }
}
