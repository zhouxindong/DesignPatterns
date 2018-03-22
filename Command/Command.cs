using System;
using System.Collections.Generic;

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class NullCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("null command execute");
        }

        public void Undo()
        {
            Console.WriteLine("null command undo");
        }
    }

    public class WriteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("write command execute");
        }

        public void Undo()
        {
            Console.WriteLine("write command undo");
        }
    }

    public class PlusCommand : ICommand
    {
        public void Execute()
        {
            
        }

        public void Undo()
        {
            
        }
    }

    public class MacroCommand : ICommand
    {
        private readonly IList<ICommand> _commands;
        public MacroCommand(IList<ICommand> commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}