using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int Discount) : base(Discount)
        {
            Price = 20;
        }
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
