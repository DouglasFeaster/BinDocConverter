using Newtonsoft.Json;

namespace DocumentDiffer.Models
{
    public class FileExtensionsModel
    {
        [JsonProperty("Applications")]
        public ApplicationsModel Applications { get; set; }
    }
}
