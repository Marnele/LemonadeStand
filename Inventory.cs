using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Inventory
    {
        private int lemons;
        private int cupsOfSugar;
        private int cups;
        private int ice;
        private int pitcher;
        private int cupsOfLemonade;

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
