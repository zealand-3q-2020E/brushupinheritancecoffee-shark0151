using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee , Milk
    {

        public Latte(int Discount):base(Discount)
        {
            Price = 40;
        }
        public int gotMilk()
        {
            return 200;
        }

        public override int price()
        {
            return base.price();
        }

        public override string strength()
        {
            return Strength.Weak.ToString();
        }
    }
}
