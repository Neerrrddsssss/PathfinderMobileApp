using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderApp
{
    public class Character 
    {
        private Race race;
        private ClassType classType;
        private int currentHitPoints;
        private int maxHitPoints;
        
        public BaseStat intelligence;
        public BaseStat charisma;
        public BaseStat strength;
        public BaseStat dexterity;
        public BaseStat wisdom;
        public BaseStat constitution;

        //default constructor
        public Character(){ }

        //constructor is basestats are unkown/not needed yet
        public Character(Race r, ClassType ct, int chp, int mhp)
        {
            this.race = r; this.classType = ct; this.currentHitPoints = chp; this.maxHitPoints = mhp;
        }

        //overloaded constructor
        public Character(Race r, ClassType ct, int chp, int mhp, BaseStat i, BaseStat charis, BaseStat s, BaseStat d, BaseStat w, BaseStat cons)
        {
            this.race = r; this.classType = ct; this.currentHitPoints = chp; this.maxHitPoints = mhp; this.intelligence = i;
            this.charisma = charis; this.strength = s; this.dexterity = d; this.wisdom = w; this.constitution = cons;
        }

        //public call to get this characters race obj
        public Race getRace()
        {
            return this.race;
        }

        //returns the string value of the race
        public string getRaceType()
        {
            return this.race.getType();
        }

        //public call to get this characters class
        public ClassType getClass()
        {
            return this.classType;
        }

        //return this string value of the type
        public string getClassType()
        {
            return this.classType.getClassType();
        }

        //public call to get this characters hp
        public int getCurrentHitpoints()
        {
            return this.currentHitPoints;
        }

        //get max hp for char
        public int getMaxHitPoints()
        {
            return maxHitPoints;
        }
    }
}
