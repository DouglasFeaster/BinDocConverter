using Newtonsoft.Json;
using System.Collections.Generic;

namespace BinDocConverter.Models
{
    public class HelpDocumentationModel
    {
        [JsonProperty("Usage")]
        public string Usage { get; set; }

        [JsonProperty("Examples")]
        public List<string> Examples { get; set; }
    }
}
