using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Store
    {
        //members variables 
        public double lemons;
        public double cupBundle;
        public double bagOfIce;
        public double sugar;

        public string name;
        public double price;
        string[] productList;
        double[] productPrice;

        public Store()
        {
            productList = new string[4] {"Lemons", "Cups", "Ice", "Sugar" };
            productPrice = new double[4] { 1.00, 1.00, 2.00, 3.00 };
        }

        public void DisplayStore()
        {
            Console.WriteLine("Welcome to the store");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(productList[i] + "Price: "+ productPrice[i]);
            }
        }

        public void Purchase(Player player)
        {
            Console.WriteLine("Press (1) to buy Lemons, \n Press (2) to buy Cups, \n Press (3) to buy Ice \n Press (4) to buy Sugar \n Press (5) to begin selling");
            var itemPurchased = Console.ReadLine();
            switch (itemPurchased)
            {
                case "1":
                    Console.WriteLine("How many lemons do you want to buy?"); //Ask for player input
                    int numBought = int.Parse(Console.ReadLine()); //Creates a variable that holds parsed input
                    BuyLemons(player, numBought); //Creates a method that receives number in a parameter
                    break;
                case "2":
                    Console.WriteLine("How many cups do you want to buy?");
                    int numBought = int.Parse(Console.ReadLine());
                    BuyCups(player, numBought);
                    break;
                case "3":
                    Console.WriteLine("How much sugar do you want to buy?");
                    int numBought = int.Parse(Console.ReadLine());
                    BuyIce(player, numBought);
                    break;
                case "4":
                    Console.WriteLine("How much ice do you want to buy?");
                    int numBought = int.Parse(Console.ReadLine());
                    BuySugar(player, numBought);
                    break;
                case "5":
                    Game game = new Game();
                    game.ExecuteGame();
                    break;
                default:
                    Console.WriteLine("Oops, Wrong input.Please choose option 1,2,3 or 4");
                    break;
            }
        }

        public void BuyLemons(Player player, int numBought)
        {
            player.inventory.lemons += numBought;
            player.Monetary -= productPrice[0] * numBought;
        }

        public void BuyCups(Player player, int numBought)
        {
            player.inventory.cups += numBought;
            player.Monetary -= productPrice[1] * numBought;
        }

        public void BuySugar(Player player, int numBought)
        {
            player.inventory.cupsOfSugar += numBought;
            player.Monetary -= productPrice[4] * numBought;
        }
        public void BuyIce(Player player, int numBought)
        {
            player.inventory.ice += numBought;
            player.Monetary -= productPrice[3] * numBought;
        }

        public void ProductPrice(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
  
    }

}

