using System;
namespace LemonadeStandUserStories
{
    public class Game : Program
    {
        private Player newPlayer;
        public Day newDay;
        public Store newStore;
        public Game game;

        internal Player NewPlayer { get => newPlayer; set => newPlayer = value; }



        /// <summary>
        /// I want the player to see current inventory and daily forcast 
        /// </summary>
        public void ExecuteGame()
        {

        }
    }
}
