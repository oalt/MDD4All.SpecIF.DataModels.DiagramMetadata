using MDD4All.SpecIF.DataModels.DiagramMetadata.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    [JsonConverter(typeof(ShapePrimitiveCreationConverter))]
    public abstract class ShapePrimitive
    {
        [JsonProperty("shapePrimitiveType", Order = -100)]
        public ShapePrimitiveType ShapePrimitiveType { get; set; }

        [JsonProperty("x", Order = -99)]
        public double X { get; set; }

        [JsonProperty("y", Order = -98)]
        public double Y { get; set; }

        //[JsonProperty("z", Order = -98)]
        //public int Z { get; set; }

        [JsonProperty("width", Order = -96)]
        public double Width { get; set; }

        [JsonProperty("height", Order = -95)]
        public double Height { get; set; }

        [JsonProperty("style", Order = -94)]
        public string Style { get; set; }
    }
}
