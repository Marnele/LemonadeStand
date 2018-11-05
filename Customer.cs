using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Customer
    {
        public int newAge;
        public int desireToBuy;
        public int hasMoney;
        public int desiredTemp;
        public int newCustomer;

        /// <summary>
        /// I want the customer to make a purchase if they are thirsty, 
        /// have spare change, are residents in the neighborhood, and todays weather is good.
        /// </summary>

            public Customer()
            {
                Random random = new Random();
                newAge = random.Next(15, 65);
            }


    }

}

