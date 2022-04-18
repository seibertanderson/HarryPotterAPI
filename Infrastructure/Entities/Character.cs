using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public House House { get; set; }

        public Character(int id, string name, House house)
        {
            Id = id;
            Name = name;
            House = house;
        }
    }
}
