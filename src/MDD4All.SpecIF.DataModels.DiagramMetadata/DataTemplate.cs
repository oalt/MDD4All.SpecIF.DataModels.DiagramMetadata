using Newtonsoft.Json;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    public class DataTemplate
    {
        [JsonProperty("resources")]
        public List<Resource> Resources { get; set; } = new List<Resource>();

        [JsonProperty("statements")]
        public List<Statement> Statements { get; set; } = new List<Statement>();
    }
}
