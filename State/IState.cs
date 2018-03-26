using System;

namespace State
{
    public interface IState
    {
        void Handle();
    }

    public class GoodState : IState
    {
        public void Handle()
        {
            Console.WriteLine("I'm good!");
        }
    }

    public class NormalState : IState
    {
        public void Handle()
        {
            Console.WriteLine("I'm normal!");
        }
    }

    public class BadlyState : IState
    {
        public void Handle()
        {
            Console.WriteLine("I'm badly!");
        }
    }
}