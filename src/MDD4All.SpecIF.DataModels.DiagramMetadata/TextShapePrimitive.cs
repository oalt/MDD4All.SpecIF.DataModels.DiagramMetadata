using MDD4All.Text.DataModels;
using Newtonsoft.Json;

namespace MDD4All.SpecIF.DataModels.DiagramMetadata
{
    public class TextShapePrimitive : ShapePrimitive
    {
        public TextShapePrimitive() 
        {
            ShapePrimitiveType = ShapePrimitiveType.Text;
        }

        [JsonProperty("value")]
        public string Value { get; set; } = "***";

        [JsonProperty("wrapText")]
        public bool WrapText { get; set; } = false;

        [JsonProperty("horizontalAlignment")]
        public HorizontalTextAlignment HorizontalAlignment { get; set; } = HorizontalTextAlignment.Center;

        [JsonProperty("verticalAlignment")]
        public VerticalTextAlignment VerticalAlignment { get; set; } = VerticalTextAlignment.Center;

        [JsonProperty("isFixed")]
        public bool IsFixed { get; set; } = true;

        [JsonProperty("fontSize")]
        public int FontSize { get; set; } = 14;

        [JsonProperty("fontFamily")]
        public FontFamily FontFamily { get; set; } = FontFamily.SansSerif;

        [JsonProperty("fontStyle")]
        public FontStyle FontStyle { get; set; } = FontStyle.Normal;

        [JsonProperty("fontWeight")]
        public FontWeight FontWeight { get; set; } = FontWeight.Normal;

        [JsonProperty("fontColor")]
        public string FontColor { get; set; } = "black";
    }
}
