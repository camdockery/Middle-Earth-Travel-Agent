using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    internal class LocationLoader
    {
        public static List<Location> LoadLocations()
        {
            string fileName = "locations.json";
            string jsonString = File.ReadAllText(fileName, Encoding.UTF8);
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(jsonString)!;
            return locations;
        }
    }
}
