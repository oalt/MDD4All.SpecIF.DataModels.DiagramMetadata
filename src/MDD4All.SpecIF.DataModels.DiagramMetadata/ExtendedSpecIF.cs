using MDD4All.SpecIF.DataModels.DiagramMetadata;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DataModels
{
    public class ExtendedSpecIF : SpecIF
    {
        public ExtendedSpecIF() 
        {
            Schema = "https://specif.de/v3.0/schema.json";
        }

        [BsonIgnore]
        [JsonProperty(PropertyName = "diagramObjectClasses", Order = 19)]
        public List<DiagramObjectClass> DiagramObjectClasses { get; set; } = new List<DiagramObjectClass>();
    }
}
