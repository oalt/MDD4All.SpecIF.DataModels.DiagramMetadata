using MDD4All.SpecIF.DataModels.DiagramMetadata.Converters;
using Newtonsoft.Json;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    //[JsonConverter(typeof(ShapePrimitiveConverter))]
    public class RectangleShapePrimitive : ShapePrimitive
    {
        public RectangleShapePrimitive() 
        {
            ShapePrimitiveType = ShapePrimitiveType.Rectangle;
        }

        [JsonProperty("rx")]
        public int HorizontalRadius { get; set; }

        [JsonProperty("ry")]
        public int VerticalRadius { get; set; }
    }
}
