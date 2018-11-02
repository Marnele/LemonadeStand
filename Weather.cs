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


        public void newWnewWeathereather()
        {
            Console.WriteLine("Todays Forcast is: " + Temperature + "degress" + CloudCover );
        }

        public void Clouds()
        {
            DailyClouds = new string[4] { "Sunny", "Lightly Cloudy", "Cloudy", "Rain"};
            Random rnd = new Random();
            CloudCover = DailyClouds[rnd.Next(0, 4)];
            
        }

        public void Temp()
        {
            DailyTemp = new int[7] { 92, 80, 77, 75, 68, 65, 47 };
            Random rnd = new Random();
            Temperature = DailyTemp[rnd.Next(0, 7)];
        }

    //public void DailyTemp()
        //{
        //    int[] temperature = new int[6];
        //    temperature[0] = 80;
        //    temperature[1] = 65;
        //    temperature[2] = 92;
        //    temperature[3] = 75;
        //    temperature[4] = 47;
        //    temperature[5] = 68;
        //    temperature[6] = 77;
        //    Random rnd = new Random();
        //    Temperature = temperature[rnd.Next(0, 6)];
        //    Console.WriteLine(Temperature);

        //}

        //public void DailyCLouds()
        //{
        //    string[] cloudCover = new string[4];
        //    cloudCover[0] = "Sunny";
        //    cloudCover[1] = "Light Clouds";
        //    cloudCover[2] = "Cloudy";
        //    cloudCover[3] = "Rain";
        //    Random rnd = new Random();
        //    DailyClouds = cloudCover[rnd.Next(0, 6)];
        //    Console.WriteLine(DailyClouds);
        //}

    }

}


