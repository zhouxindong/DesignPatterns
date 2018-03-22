using System;

namespace Adapter
{
    public interface IDuck
    {
        void Quack();
        void Fly();
    }

    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}