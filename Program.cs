using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Program 
    {
        static void Main()
        {
            {
                Console.WriteLine("Would you like to play LemonadeStand? yes/no");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    Game game = new Game();
                    game.ExecuteGame();

                }
                else if (answer == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Oops, Wrong input. Please choose yes or no");
                    Main();
                }
            }
        }
    }
}
