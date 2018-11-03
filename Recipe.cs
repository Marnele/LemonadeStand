using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int lemons;
        public int cupsOfSugar;
        public int cups;
        public int ice;
        public int cupsOfLemonade;

        public Recipe()
        {

        }
         
         public void NewPitcher()
            {

                if (lemons >= 4 && cupsOfSugar >= 1 && cups >= 32 && ice >= 30)
                {
                    pitcher = 1; cups = 32;
                    Console.WriteLine("You have enough to make 32 cups of Lemonade");
                }
            }
       

    }
}
