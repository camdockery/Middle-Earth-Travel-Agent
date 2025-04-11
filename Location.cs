using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Middle_Earth_Travel_Agent
{
    public class Location
    {
        //public int Id { get; set; }
        public string? name { get; set; }
        public string? region { get; set; }
        public string? description { get; set; }
        public List<string?>? activities { get; set; }
        public string? recommendedSeason { get; set; }
    }
}
