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
        public string DailyClouds;
        public bool FavorableWeather;


        public void DailyForecast(string clouds, int temp)
        {
            CloudCover = clouds;
            Temperature = temp;

            if(CloudCover != "Rain" && Temperature >= 70){
                FavorableWeather = true;
            }
            else{
                FavorableWeather = false;
            }
        }

        public void DailyTemp()
        {
            int[] temperature = new int[6];
            temperature[0] = 80;
            temperature[1] = 65;
            temperature[2] = 92;
            temperature[3] = 75;
            temperature[4] = 47;
            temperature[5] = 68;
            temperature[6] = 77;
            Random rnd = new Random();
            Temperature = temperature[rnd.Next(0, 6)];
            Console.WriteLine(Temperature);

        }

        public void DailyCLouds()
        {
            string[] cloudCover = new string[4];
            cloudCover[0] = "Sunny";
            cloudCover[1] = "Light Clouds";
            cloudCover[2] = "Cloudy";
            cloudCover[3] = "Rain";
            Random rnd = new Random();
            DailyClouds = cloudCover[rnd.Next(0, 6)];
            Console.WriteLine(DailyClouds);
        }

    }

}


