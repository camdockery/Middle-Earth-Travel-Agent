using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    /*
     * Reads the months.json file and loads them
     */
    internal class MonthsLoader
    {
        /*
         * Loads the months from the json
         */
        public static String[] LoadMonths()
        {
            string fileName = "months.json";
            //Reads all the text from months.json
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            //Deserializes the read string and inserts it into a string array
            String[] months = JsonSerializer.Deserialize<String[]>(jsonString)!;
            return months;
        }
    }
}
