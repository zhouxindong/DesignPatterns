using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Monostate();
            var obj2 = new Monostate();

            obj1.X = 10;
            Console.WriteLine(obj2.X);
            Console.ReadKey();

            obj2.X = 99;
            Console.WriteLine(obj1.X);
            Console.ReadKey();
        }
    }
}
