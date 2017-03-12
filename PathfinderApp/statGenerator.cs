using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PathfinderApp
{
    public static class statGenerator
    {

        
        //roll a 20 sided die
        public static int d20Roll()
        {
            Random rd = new Random();
            return rd.Next(1, 20);
        }

        //get ability modifier
        public static int abilityModifier(int ability)
        {
            return ((ability - 10) / 2);
        }

        //roll a 4 sided die
        public static int d4Roll()
        {
            Random rd = new Random();
            return rd.Next(1, 4);
        }

        //roll a 8 sided die
        public static int d8Roll()
        {
            Random rd = new Random();
            return rd.Next(1, 8);
        }

        //roll a 12 sided die
        public static int d12Roll()
        {
            Random rd = new Random();
            return rd.Next(1, 12);
        }

    }
}