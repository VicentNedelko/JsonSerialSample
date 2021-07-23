using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace JSerial
{
    public class Response
    {
        [JsonPropertyName("order")]
        public OrderResponse OrderResp { get; set; }
        public class OrderResponse
        {
            [JsonPropertyName("accepted")]
            public bool Accepted { get; set; }
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("reason")]
            [JsonConverter(typeof(ReasonJsonConverter))]
            public Reason Reason { get; set; }
        }

        public static string ReasonEnumToString(Reason reason)
        {
            return reason switch
            {
                Reason.OUT_OF_DATE => "OUT_OF_DATE",
                _ => "UNKNOWN",
            };
        }


    }
}
