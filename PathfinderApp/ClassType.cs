using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PathfinderApp
{

    public class ClassType
    {
        //constant class variations.  same as normal variable, but cant be changed.  good when this
        //since once you have your race/class you dont want that to change
        public const string
            Rouge = "Rouge", SomethingElse = "SomethingElse", HarryPotter = "HarryPotter", LunaLovegood = "LunaLovegood";

        private string charClass;


        //constructors
        public ClassType() { }

        public ClassType(string c)
        {
            this.charClass = c;
        }


        //getters/setters
        public string getClassType()
        {
            return this.charClass;
        }

        public void setClassType(string c)
        {
            this.charClass = c;
        }
    }
}
