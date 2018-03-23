using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.Description + " $" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2); // add a Mocha
            beverage2 = new Mocha(beverage2); // add another Mocha
            beverage2 = new Whip(beverage2); // add a Whip
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());

            Console.ReadKey();
        }
    }
}
