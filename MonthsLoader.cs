using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    internal class MonthsLoader
    {
        public static String[] LoadMonths()
        {
            string fileName = "months.json";
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            String[] months = JsonSerializer.Deserialize<String[]>(jsonString)!;
            return months;
        }
    }
}
