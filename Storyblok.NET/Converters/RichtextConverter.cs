using Storyblok.NET.Fields;
using System.Text.Json;

namespace Storyblok.NET.Converters
{
    public class RichtextConverter : System.Text.Json.Serialization.JsonConverter<Richtext>
    {
        public override Richtext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {

            if (reader.TokenType == JsonTokenType.Null) return null;

            // Check first if previous field is string(textfield, textarea or markdown)
            if (reader.TokenType == JsonTokenType.String)
            {
                var content = reader.GetString();
                return new Richtext
                {
                    PreviousFieldValue = content
                };
            }

            return JsonSerializer.Deserialize<Richtext>(ref reader);

        }

        public override void Write(Utf8JsonWriter writer, Richtext value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
