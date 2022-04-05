using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("../../../data/exampleFile.json");
            Dictionary<string, JArray> dic = JsonConvert.DeserializeObject<Dictionary<string, JArray>>(json);
            Console.WriteLine("{0,-20} {1,5}\n", "Name", "Values");
            foreach (var item in dic)
            {
                Console.WriteLine("{0,-20} {1,5}\n", item.Key, string.Join(" ", item.Value.Select(jv => (int)jv).ToArray()));
            }
        }
    }
}
