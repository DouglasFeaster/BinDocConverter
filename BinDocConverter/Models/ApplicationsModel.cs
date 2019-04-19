using Newtonsoft.Json;
using System.Collections.Generic;

namespace BinDocConverter.Models
{
    public class ApplicationsModel 
    {
        [JsonProperty("Word")]
        public List<string> Word { get; set; }

        [JsonProperty("Excel")]
        public List<string> Excel { get; set; }

        [JsonProperty("Power Point")]
        public List<string> PowerPoint { get; set; }

        [JsonProperty("Adobe")]
        public List<string> Adobe { get; set; }
    }
}
