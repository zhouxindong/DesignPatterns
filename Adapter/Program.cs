using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck fake_duck = new TurkeyAdapter(new WildTurkey());
            fake_duck.Quack();
            fake_duck.Fly();

            Console.ReadKey();
        }
    }
}
