using Newtonsoft.Json;
using System.Collections.Generic;

namespace DocumentDiffer.Models
{
    public class HelpDocumentationModel
    {
        [JsonProperty("Usage")]
        public string Usage { get; set; }

        [JsonProperty("Examples")]
        public List<string> Examples { get; set; }
    }
}
