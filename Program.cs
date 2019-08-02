using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleJSONParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonData = ReadFile("./jsons/models.v1.json");
            var stockModels = JsonConvert.DeserializeObject<List<StockModel>>(jsonData);

            Console.WriteLine($"Stock models {stockModels.Count}");

            // string jsonData = ReadFile("./jsons/shipment.v5.json");
            // var transactionInfo = JsonConvert.DeserializeObject<TransactionInfoResponse>(jsonData);

            // Console.WriteLine($"transactionInfo {transactionInfo} - {transactionInfo.Shipment.items.Count} / {transactionInfo.Shipment.events.Count}");

        }

        public static string ReadFile(string fileName){
            using (StreamReader r = new StreamReader(fileName))
            {
                return r.ReadToEnd();
            }
        }
    }

}
