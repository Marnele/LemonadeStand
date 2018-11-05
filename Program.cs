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
                Console.WriteLine("Are you ready to play LemonadeStand? yes/no");
                var answer = Console.ReadLine().ToLower();
               
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
                Main();
                }


            //Game game = new Game();
            //game.ExecuteGame();

        }
    }
}
