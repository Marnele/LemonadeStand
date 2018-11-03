using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Day
    {
        public void DisplayStore()
        {
            Console.WriteLine("Welcome to the store");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(productList[i] + "Price: " + productPrice[i]);
            }
        }
    }

}
