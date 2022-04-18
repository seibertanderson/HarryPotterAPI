using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class House
    {
        public int Id { get; set; }
        [JsonProperty("House Name")] // ver como usar isso
        public string HouseName { get; set; }

        public House(int id, string houseName)
        {
            Id = id;
            HouseName = houseName;
        }
    }
}
