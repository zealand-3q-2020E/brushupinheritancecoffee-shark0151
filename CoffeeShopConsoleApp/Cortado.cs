using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Cortado : Coffee, Milk
    {
        public Cortado(int Discount) : base(Discount)
        {
            Price = 25;
        }
        public override int price()
        {
           return base.price();
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
