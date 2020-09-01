using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, Milk
    {
        public override int price()
        {
            return 25;
        }
        public int gotMilk()
        {
            return 40;
        }

        public override string strength()
        {
            return Strength.Medium.ToString();
        }
    }
}
