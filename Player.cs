using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandUserStories
{
    abstract class Player
    {
        //members variables 
        public int Monetary;
        public int Inventory;


        public abstract void PlayerResources();
        public abstract void DailyRecipe();

    }
}