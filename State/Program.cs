using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            IState state = new NormalState();
            Context context = new Context(state);
            context.Request();
            context.State = new GoodState();
            context.Request();

            Console.ReadKey();
        }
    }
}
