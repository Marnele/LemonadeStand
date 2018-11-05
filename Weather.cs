using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Weather
    {
        public string CloudCover;
        public int Temperature;
        public bool FavorableWeather;
        string[] DailyClouds;
        int[] DailyTemp;

            public void Clouds()
            {
                DailyClouds = new string[4] { "Sunny", "Lightly Cloudy", "Cloudy", "Rain" };
                Random rnd = new Random();
                CloudCover = DailyClouds[rnd.Next(0, 4)];
            }

            public void Temp()
            {
                DailyTemp = new int[7] { 92, 80, 77, 75, 68, 65, 47 };
                Random rnd = new Random();
                Temperature = DailyTemp[rnd.Next(0, 7)];
            }

            public void DisplayWeather()
            {
                Console.WriteLine("Todays Forcast is: " + Temperature + "degress" + CloudCover);
            }
    }

}


