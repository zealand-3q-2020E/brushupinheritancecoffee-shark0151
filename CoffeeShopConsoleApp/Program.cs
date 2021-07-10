﻿using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(5),
                new Cortado(4),
                new BlackCoffee(6)

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price());
                if(coffee is Milk)
                Console.WriteLine("the Milk in the coffee : " + (coffee as Milk).gotMilk());
                Console.WriteLine("the strength is  : " + coffee.strength());
            }


        }
    }
}
