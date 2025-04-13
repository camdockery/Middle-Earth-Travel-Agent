using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    internal class CompanionLoader
    {
        public static String[] LoadCompanions()
        {
            string fileName = "companions.json";
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            String[] companions = JsonSerializer.Deserialize<String[]>(jsonString)!;
            return companions;
        }
    }
}
