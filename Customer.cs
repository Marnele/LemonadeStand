using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    class Customer
    {
        /// <summary>
        /// I want the customer to make a purchase if they are thirsty, 
        /// have spare change, are residents in the neighborhood, and todays weather is good.
        /// </summary>

        bool thirsty;
        bool resident;
        bool spareChange;
        bool likesLemonade;
        bool Customerthirst;

        public Customer()
        {
            public newCustomer()
            {
                bool customerThirst;
                bool customerSpareChange;
                bool customerResidence;


                int newCustomer = 0;
                do
                {
                    bool[] randomOne = new bool[2];
                    randomOne[0] = true;
                    randomOne[1] = false;
                    Random rnd = new Random();
                    customerThirst = randomOne[rnd.Next(1, 2)];
                    Console.WriteLine(customerThirst);

                    bool[] randomTwo = new bool[2];
                    randomTwo[0] = true;
                    randomTwo[1] = false;
                    Random residence = new Random();
                    customerSpareChange = randomTwo[rnd.Next(1, 2)];
                    Console.WriteLine(customerSpareChange);

                    bool[] randomThree = new bool[2];
                    randomTwo[0] = true;
                    randomTwo[1] = false;
                    Random customerThirsty = new Random();
                    customerResidence = randomTwo[rnd.Next(1, 2)];
                    Console.WriteLine(customerResidence);
                    newCustomer++;
                }
                while (newCustomer <= 100);
            
            }
        }
    }
}

