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
                    Cost = 5.2,
                    Reason = Reason.OUT_OF_DATE,
                    TimeStamp = DateTime.Now,
                }
            };

            //var serializerOptions = new JsonSerializerOptions
            //{
            //    Converters = {new ReasonJsonConverter()}
            //};
            string json = JsonSerializer.Serialize(response);
            Console.WriteLine(json);
            Console.ReadKey();
            Console.WriteLine("--------------------");
            Response responseDeserialized = new Response();
            responseDeserialized = JsonSerializer.Deserialize<Response>(json);
            Console.ReadKey();
        }
    }
}
