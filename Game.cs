using System;
namespace LemonadeStandUserStories
{
    public class Game
    {
        public Day newDay;
        public Store newStore;
        public Game game;
        public Player player;

        public Game()
        {
            player = new Player();
            newDay = new Day();
            newStore = new Store();

        }

        /// <summary>
        /// I want the player to see current inventory and daily forcast 
        /// </summary>
        public void ExecuteGame()
        {
            newStore.DisplayStore();
            newStore.Purchase(player);

        }
        public void ExecuteDay()
        {
            newStore.DisplayStore();
            newStore.Purchase(player);

        }
    }
}
