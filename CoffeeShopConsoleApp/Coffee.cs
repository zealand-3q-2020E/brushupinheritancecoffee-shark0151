using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        
        public Coffee(int newDiscount)
        {
            Discount = newDiscount;
        }
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        /// 
        public virtual int price()
        {
            if (Price * Discount / 100 > 5)
            {
                throw new Exception("discount too high");
            }
            return Price - Price * Discount/100;
        }
        private int _price = 20;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _discount;
        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        


        public abstract string strength();

        public enum Strength { Weak,Medium,Strong };

    }
}
