using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    /*
     * Reads the companion.json and loads them
     */
    internal class CompanionLoader
    {
        /*
         * Loads the companions
         */
        public static String[] LoadCompanions()
        {
            string fileName = "companions.json";
            //Reads all text into a json string
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            //Deserializes the json string into a string array
            String[] companions = JsonSerializer.Deserialize<String[]>(jsonString)!;
            return companions;
        }
    }
}
