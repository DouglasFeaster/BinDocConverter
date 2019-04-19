using Newtonsoft.Json;

namespace BinDocConverter.Models
{
    public class FileExtensionsModel
    {
        [JsonProperty("Applications")]
        public ApplicationsModel Applications { get; set; }
    }
}
