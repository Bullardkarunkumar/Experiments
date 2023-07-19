using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETS.Parameters
{
    public partial class SwitchParameters
    {

    }
    public partial class ParametersTypeInfo
    {
        [JsonProperty("MAX_EMCENTERS", NullValueHandling = NullValueHandling.Ignore)]
        public int MAX_EMCENTERS { get; set; }
        [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]

        public int MAX_SLOTS_PER_EMCENTER = 7;
        public int MAX_EMCENTER_SLOTS = 70;
        public string DEFAULT_CONFIG_STRING = "0000000|0000000|0000000|0000000|0000000|0000000|0000000|0000000|0000000|0000000|";

    }
}
