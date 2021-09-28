using Newtonsoft.Json;
using System;

namespace InventoryManageentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Data Management Program");
            JSONRead json = new JSONRead();

            var data = json.Read("D:/BridgeLabzEdu/.NetPractivceProblems_BridgeLabz/Grains.json");

            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}
