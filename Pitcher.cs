using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public Pitcher newPitcher;
        public int lemons;
        public int cupsOfSugar;
        public int cups;
        public int ice;
        public int pitcher;
        public int cupsOfLemonade;

        public Pitcher()
        {
            newPitcher = new Pitcher();
        }
         
         public void NewPitcher()
            {
            if (lemons >= 4 && cupsOfSugar >= 1 && cups >= 32 && ice >= 30)
                {
                newPitcher = 1;
                }
            }
       

    }
}
