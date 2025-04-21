using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    /*
     * A custom location class
     */
    public class Location
    {
        //The Middle Earth location name
        public string? name { get; set; }
        //The Middle Earth location region's name
        public string? region { get; set; }
        //The Middle Earth location's description
        public string? description { get; set; }
        //The Middle Earth location's recommended activities
        public List<string?>? activities { get; set; }
        //The Middle Earth location's recommended season to travel
        public string? recommendedSeason { get; set; }
    }
}
