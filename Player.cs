using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    public class Player
    {
        //members variables 
        public double Monetary = 50;
        public Inventory inventory = new Inventory();


        public abstract void PlayerResources();
        public abstract void DailyRecipe();

    }
}