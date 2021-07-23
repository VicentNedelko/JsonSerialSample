using System;
using System.Text.Json;

namespace JSerial
{
    class Program
    {
        static void Main(string[] args)
        {
            Response response = new Response
            {
                OrderResp = new Response.OrderResponse
                {
                    Accepted = true,
                    Id = Guid.NewGuid().ToString().Substring(0, 5),
                    Reason = Reason.OUT_OF_DATE,
                }
            };

            //var serializerOptions = new JsonSerializerOptions
            //{
            //    Converters = {new ReasonJsonConverter()}
            //};
            string json = JsonSerializer.Serialize(response);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
