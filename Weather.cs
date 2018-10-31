using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Weather
    {
        public static void Main()
        {
            Weather newDay = new Weather();
            Console.WriteLine("Todays weather forcast is:");
        }
        
        public void DailyForcast(int temp, int rain)
        { 

        }
       
        public int ChanceOfRain()
            {
            string[] cloudCover = new string[4];
            cloudCover[0] = "Sunny";
            cloudCover[1] = "Light Clouds";
            cloudCover[2] = "Cloudy";
            cloudCover[3] = "Cloudy";
            Random rnd = new Random();
            Console.WriteLine(cloudCover[rnd.Next(0, 4)]);
            }

    }
}
