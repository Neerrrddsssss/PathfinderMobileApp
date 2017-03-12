using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderApp
{
    
    
    /*
     Race - const for characters race, can be linked to
     */
    public class Race
    {
        //enter all races as const strings. creates strings of non changing elements
        //allows for creating more concrete definitions without making 
        //individual classes for each. So now you are checking values off of Race.Dwarf not the string 'dwarf'
        // which can be misstyped/prone to error and is slower in memory to evaluate.
        public const string
            Dwarf = "Dwarf", Elf = "Elf", Human = "Human";

        private string type;

        //constructors
        public Race()
        {

        }

        public Race(string raceType)
        {
            this.type = raceType;
        }


        //getters/setters
        public string getType()
        {
            return this.type;
        }

        public void setType(string raceType)
        {
            this.type = raceType;
        }
    }
}
