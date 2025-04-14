using MDD4All.SpecIF.DataModels.BaseTypes;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    public class DiagramObjectClass : TypeDefinitionBase
    {
        [JsonProperty("shapePrimitives")]
        public List<ShapePrimitive> ShapePrimitives { get; set; } = new List<ShapePrimitive>();

        [JsonProperty(PropertyName = "icon")]
        [BsonElement("icon")]
        public string Icon { get; set; }

        [JsonProperty("isPort")]
        public bool IsPort { get; set; }

        [JsonProperty("canResize")]
        public bool CanResize { get; set; } = true;

        [JsonProperty("canRotate")]
        public bool CanRotate { get; set; } = false;

        [JsonProperty("dataTemplate")]
        public DataTemplate DataTemplate { get; set; } = new DataTemplate();

        [JsonProperty("mapsTo")]
        public MapsTo MapsTo { get; set; } = new MapsTo();
    }
}
