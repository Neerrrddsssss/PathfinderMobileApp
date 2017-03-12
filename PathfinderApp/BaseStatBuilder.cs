using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PathfinderApp
{
    /// <summary>
    /// Class to automatically adjust/create the base stats of a character based on given race/class
    /// </summary>
    public static class BaseStatBuilder
    {
        /// <summary>
        /// creates the base stats of a character depending on race
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
       public static Character buildRaceBaseStats(Character c)
        {
            //find out the kind of race it is and apply standardized stats
            switch (c.getRaceType())
            {
                //dwarf or human
                case Race.Dwarf:
                case Race.Human:
                    c.intelligence = new BaseStat(9, 10, 10, "10");
                    c.strength = new BaseStat(10, 9, 10, "10");
                    c.wisdom = new BaseStat(9, 9, 9, "10");
                    c.dexterity = new BaseStat(9, 9, 10, "10"); 
                    c.charisma = new BaseStat(9, 9, 10, "10"); 
                    c.constitution = new BaseStat(9, 9, 10, "10"); 
                    break;

                //elf
                case Race.Elf:
                    c.intelligence = new BaseStat(10, 10, 10, "10");
                    c.strength = new BaseStat(10, 10, 10, "10");
                    c.wisdom = new BaseStat(10, 10, 10, "10");
                    c.dexterity = new BaseStat(10, 10, 10, "10");
                    c.charisma = new BaseStat(10, 10, 10, "10");
                    c.constitution = new BaseStat(10, 10, 10, "10");
                    break;
            }
            // if you just wanted to adjust the class stats from here
            //c = classCharacterAdjust(c);

            //return the character that now has all base stats belonging to that race
            return c;
        }

        /// <summary>
        /// Method that will take in a character and adjust stats based on class type
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Character classCharacterAdjust(Character c)
        {
            //find out the kind of class it is and adjust
            switch (c.getClassType())
            {
                case ClassType.Rouge:
                    c.intelligence.adjustStat(2, 4, 2, "2");
                    c.strength.adjustStat(-2, 4, 2, "2");
                    c.wisdom.adjustStat(2, -4, 2, "2");
                    c.dexterity.adjustStat(-2, 4, 2, "2");
                    c.charisma.adjustStat(2, 4, 2, "2");
                    c.constitution.adjustStat(-2, 4, 2, "2");
                    break;

                case ClassType.LunaLovegood:
                    c.intelligence.adjustStat(2, -4, 2, "2");
                    c.strength.adjustStat(2, 4, 2, "2");
                    c.wisdom.adjustStat(2, -4, 2, "2");
                    c.dexterity.adjustStat(2, 4, 2, "2");
                    c.charisma.adjustStat(2, -4, 2, "2");
                    c.constitution.adjustStat(2, 4, 2, "2");
                    break;
                case ClassType.HarryPotter:
                    c.intelligence.adjustStat(2, -4, 2, "2");
                    c.strength.adjustStat(2, 4, 2, "2");
                    c.wisdom.adjustStat(2, -4, 2, "2");
                    c.dexterity.adjustStat(2, 4, 2, "2");
                    c.charisma.adjustStat(2, -4, 2, "2");
                    c.constitution.adjustStat(2, 4, 2, "2");
                    break;
                case ClassType.SomethingElse:
                    c.intelligence.adjustStat(2, -4, 2, "2");
                    c.strength.adjustStat(2, 4, 2, "2");
                    c.wisdom.adjustStat(2, -4, 2, "2");
                    c.dexterity.adjustStat(2, 4, 2, "2");
                    c.charisma.adjustStat(2, -4, 2, "2");
                    c.constitution.adjustStat(2, 4, 2, "2");
                    break;
            }
            return c;
        }
    }
}