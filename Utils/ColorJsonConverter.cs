using System.Text.Json;
using System.Text.Json.Serialization;

namespace StatsTracker.Utils;

public class ColorJsonConverter : JsonConverter<Color>
{
    private static ColorConverter _converter = new();
    
    public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return (Color)_converter.ConvertFromString(reader.GetString() ?? "")!;
    }

    public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(_converter.ConvertToString(value));
    }
}