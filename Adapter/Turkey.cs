using System;

namespace Adapter
{
    public interface ITurkey
    {
        void Gobble();
        void Fly();
    }

    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a short distance");
        }
    }

}