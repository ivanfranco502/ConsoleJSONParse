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
            string jsonData = ReadFile();
            var stockModels = JsonConvert.DeserializeObject<List<StockModel>>(jsonData);

            Console.WriteLine($"Stock models {stockModels.Count}");
        }

        public static string ReadFile(){
            using (StreamReader r = new StreamReader("models.json"))
            {
                return r.ReadToEnd();
            }
        }
    }

}
