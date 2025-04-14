using Newtonsoft.Json;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    public class MapsTo
    {
        [JsonProperty("stereotype")]
        public string Stereotype { get; set; } = string.Empty;

        [JsonProperty("type")]
        public string Type { get; set; } = string.Empty;
    }
}
