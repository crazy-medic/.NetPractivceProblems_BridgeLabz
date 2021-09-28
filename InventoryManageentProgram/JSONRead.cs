using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace InventoryManageentProgram
{
    class JSONRead
    {
        public Grain Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
                try
                {
                    string json = file.ReadToEnd();
                    var searializerSettings = new JsonSerializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<Grain>(json, searializerSettings);
                }
                catch
                {
                    Console.WriteLine("Error in reading file");
                    return null;
                }
        }
    }
}
