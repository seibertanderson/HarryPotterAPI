using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AllDataTemp
    {
        public static List<House> Houses = new List<House>()
        {
            new House(1, "Gryffindor"),
            new House(2, "Hufflepuff"),
            new House(3, "Slytherin"),
            new House(4, "RavenClaw")
        };

        public static List<Character> Characters = new List<Character>()
        {

            new Character(1,"Harry Potter", Houses.Where(x=>x.HouseName == "Gryffindor").FirstOrDefault()),
            new Character(2,"Hermione Jean Granger", Houses.Where(x=>x.HouseName == "Gryffindor").FirstOrDefault()),
            new Character(3,"Ronald Abílio Weasley", Houses.Where(x=>x.HouseName == "Gryffindor").FirstOrDefault())
        };
    }
}
