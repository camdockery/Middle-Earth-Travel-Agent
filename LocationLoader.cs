using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    /*
     * Reads the locations.json and loads them
     */
    internal class LocationLoader
    {
        /*
         * Loads the locations
         */
        public static List<Location> LoadLocations()
        {
            string fileName = "locations.json";
            //Reads all the texts into a string
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            //Deserializes the json string and loads it into a Location array
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(jsonString)!;
            return locations;
        }
    }
}
