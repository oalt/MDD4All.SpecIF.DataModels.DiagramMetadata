using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShapePrimitiveType
    {
        Rectangle,
        Circle,
        Ellipse,
        Text,
        ConnectionPoint,
        ConnectionArea
    }
}
