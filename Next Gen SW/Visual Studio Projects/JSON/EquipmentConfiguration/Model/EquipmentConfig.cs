//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.8.0.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace MyNamespace
{
    #pragma warning disable // Disable all warnings

    /// <summary>
    /// JSON Schema for Equipment Configuration
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Json
    {
        /// <summary>
        /// Unique equipment name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// ETS-Lindgren defined class of equipment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JsonClass Class { get; set; }

        /// <summary>
        /// ETS-Lindgren defined type or sub-class of equipment
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JsonType Type { get; set; }

        /// <summary>
        /// Equipment driver from the available list
        /// </summary>
        [Newtonsoft.Json.JsonProperty("driver", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JsonDriver Driver { get; set; }

        /// <summary>
        /// Workstation from which the connection to the equipment is to be made
        /// </summary>
        [Newtonsoft.Json.JsonProperty("workstation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Workstation { get; set; }

        /// <summary>
        /// An array of connection strings
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connection", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<Connection> Connection { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JsonClass
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Positioner")]
        Positioner = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"Switch")]
        Switch = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"Network Analyzer")]
        Network_Analyzer = 2,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JsonType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ETS-EMControl")]
        ETSEMControl = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"ETS-2006")]
        ETS2006 = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"RS-ZNB")]
        RSZNB = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"Agilent-PNA-X")]
        AgilentPNAX = 3,


        [System.Runtime.Serialization.EnumMember(Value = @"ETS-EMSwitch")]
        ETSEMSwitch = 4,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum JsonDriver
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ETS-Lindgren EMControl")]
        ETSLindgren_EMControl = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"ETS-Lindgren Positioner")]
        ETSLindgren_Positioner = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"RS ZVA")]
        RS_ZVA = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"ZVB")]
        ZVB = 3,


        [System.Runtime.Serialization.EnumMember(Value = @"ZVT Series")]
        ZVT_Series = 4,


        [System.Runtime.Serialization.EnumMember(Value = @"Agilent PNA Series")]
        Agilent_PNA_Series = 5,


        [System.Runtime.Serialization.EnumMember(Value = @"ETS-Lindgren EMSwitch")]
        ETSLindgren_EMSwitch = 6,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Connection
    {
        /// <summary>
        /// Equipment communication protocol
        /// </summary>
        [Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ConnectionProtocol Protocol { get; set; }

        /// <summary>
        /// Connection string
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address-string", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddressString { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.8.0.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ConnectionProtocol
    {

        [System.Runtime.Serialization.EnumMember(Value = @"VISA")]
        VISA = 0,


    }
}