﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Game
    {
        public Day newDay;
        public Store newStore;
        public Game game;
        public Player player;
        public Weather newWeather;


        public Game()
        {
            game = new Game();
            player = new Player();
            newDay = new Day();
            newStore = new Store();
            newWeather = new Weather();
        }

        /// <summary>
        /// I want the player to see current inventory and daily forcast 
        /// </summary>

        public void ExecuteGame()
            {
                Console.WriteLine("Are you ready to play LemonadeStand? yes/no");
                var answer = Console.ReadLine().ToLower();
               
                if (answer == "yes")
                {
                   
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
            }


        public void ExecuteStore()
        {
            newStore.DisplayStore();
            newStore.Purchase(player);

        }
        public void ExecuteDay()
        {
            newStore.DisplayStore();
            newStore.Purchase(player);
            newWeather.DisplayWeather();

        }
        public void ExecuteMarketplace()
        {
            newStore.Purchase(player);
            newWeather.DisplayWeather();


        }
    }
}
