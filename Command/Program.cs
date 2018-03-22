using System;
using System.Collections.Generic;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new List<ICommand>();
            commands.Add(new NullCommand());
            commands.Add(new WriteCommand());
            var com = new MacroCommand(commands);
            com.Execute();

            Console.ReadKey();
        }
    }
}
