using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public override int price()
        {
            return base.price();
        }

        public override string strength()
        {
            return Strength.Strong.ToString();
        }
    }
}
