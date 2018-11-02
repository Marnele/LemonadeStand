using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Inventory
    {
        public int lemons;
        public int cupsOfSugar;
        public int cups;
        public int ice;
        public int pitcher;
        public int cupsOfLemonade;

        //members variables 
        public void Recipe()
        {
            if(lemons >= 4 && cupsOfSugar >= 1 && cups >= 1 &&  ice >= 10){
                pitcher = 1;
                cups = 32;
            }
        }
    }
}
