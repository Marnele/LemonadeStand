using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Store : Game
    {
        //members variables 
        public double lemons;
        public double cupBundle;
        public double bagOfIce;
        public double sugar;

        public void Inventory()
        {
            string[] productList = new string[4];
            productList[0] = "lemons";
            productList[1] = "cupBundle";
            productList[2] = "bagOfIce";
            productList[3] = "sugar";
            Console.WriteLine(productList);
            Console.ReadLine();

        }

    }
}
