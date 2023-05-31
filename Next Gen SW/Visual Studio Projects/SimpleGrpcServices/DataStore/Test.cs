using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions.DataStore
{
    internal class Test
    {
        public ObjectId Id { get; set; }        
        public string name { get; set; }
        public string jobNumber { get; set; }
        public DateTime date { get; set; }
        public string dutSerialNumber { get; set;}
       
        public List<Instrument> instruments;
       
    }
}
