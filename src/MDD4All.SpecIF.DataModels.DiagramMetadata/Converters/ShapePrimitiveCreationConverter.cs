using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata.Converters
{
    public class ShapePrimitiveCreationConverter : CustomCreationConverter<ShapePrimitive>
    {
        public override ShapePrimitive Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ShapePrimitive result = null;

            JObject jObject = JObject.Load(reader);

            string shapePrimitiveTypeString = jObject["shapePrimitiveType"].Value<string>();

            ShapePrimitiveType shapePrimitiveType = (ShapePrimitiveType) Enum.Parse(typeof(ShapePrimitiveType), 
                                                                                    shapePrimitiveTypeString);

            if (shapePrimitiveType == ShapePrimitiveType.Rectangle)
            {
                result = new RectangleShapePrimitive();
            }
            else if(shapePrimitiveType == ShapePrimitiveType.Text)
            {
                result = new TextShapePrimitive();
            }
            else if(shapePrimitiveType == ShapePrimitiveType.Circle)
            {
                result = new CircleShapePrimitive();
            }
            else if (shapePrimitiveType == ShapePrimitiveType.Ellipse)
            {
                result = new EllipseShapePrimitive();
            }

            serializer.Populate(jObject.CreateReader(), result);
            
            return result;
        }
    }
}
