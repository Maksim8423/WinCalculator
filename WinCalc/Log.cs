using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WinCalc
{
    public class Log
    {
        

        public void SaveJson(string operation)
        {
            string json = JsonSerializer.Serialize(operation);
            File.WriteAllText("log.json", json + "\n");
        }
        public static string LoadJson()
        {
            string json = File.ReadAllText("log.json");
            return JsonSerializer.Deserialize<string>(json);
             

        }
        static public void ClearJson()
        {
            File.WriteAllText("log.json",null);
        }

    }
}
