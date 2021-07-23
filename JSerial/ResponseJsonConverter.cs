using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSerial
{
    public class ReasonJsonConverter : JsonConverter<Reason>
    {

        public override Reason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string responseFromJson = reader.GetString();
            return responseFromJson switch
            {
                "OUT_OF_DATE" => Reason.OUT_OF_DATE,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public override void Write(Utf8JsonWriter writer, Reason value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(Response.ReasonEnumToString(value));
        }
    }
}
