using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderApp
{
    /// <summary>
    /// Base stat class for all characters
    /// </summary>
    public class BaseStat
    {
        
        private int maxInt;
        private int currentInt;
        private int tempModifier;
        private string tempModify;

        public BaseStat() { }

        public BaseStat(int max, int cur, int itemp, string temp)
        {
            this.maxInt = max;
            this.currentInt = cur;
            this.tempModifier = itemp;
            this.tempModify = temp;
        }

        /// <summary>
        /// takes in values and adjusts the stats
        /// </summary>
        /// <param name="maxI">Max Int</param>
        /// <param name="curr">Current int</param>
        /// <param name="temp">Temp Modifier(int)</param>
        /// <param name="tempM">Temp Modifier(string)</param>
        public void adjustStat(int maxI, int curr, int temp, string tempM)
        {
            this.maxInt += maxI;
            this.currentInt += curr;
            this.tempModifier += temp;
            this.tempModify += tempM;
        }
    }
}
