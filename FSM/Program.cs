using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSM
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new MyTurntileController();
            var turntile = new Turnstile(controller);
            Console.WriteLine("Initial Turntile State : {0}", turntile.State);

            turntile.HandleEvent(eTurnstileEvent.Coin);
            Console.WriteLine("After Coin, Turnstile State: {0}", turntile.State);
            Console.WriteLine("UnlockCalled? {0}", controller.UnlockCalled);

            turntile.HandleEvent(eTurnstileEvent.Coin); // 继续投币
            Console.WriteLine("After coin again, Turnstile State: {0}", turntile.State);
            Console.WriteLine("ThankyouCalled? {0}", controller.ThankyouCalled);

            turntile.HandleEvent(eTurnstileEvent.Pass);
            Console.WriteLine("After pass, now Turnstile State: {0}", turntile.State);
            Console.WriteLine("LockCalled? {0}", controller.LockCalled);

            turntile.HandleEvent(eTurnstileEvent.Pass); // 企图再次通过
            Console.WriteLine("Want to Pass Again, Turnstile State: {0}", turntile.State);
            Console.WriteLine("AlarmCalled? {0}", controller.AlarmCalled);

            Console.ReadKey();
        }
    }

    class MyTurntileController : ITurnstileController
    {
        public bool LockCalled;
        public bool UnlockCalled;
        public bool ThankyouCalled;
        public bool AlarmCalled;

        public void Lock()
        {
            LockCalled = true;
        }

        public void Unlock()
        {
            UnlockCalled = true;
        }

        public void Thankyou()
        {
            ThankyouCalled = true;
        }

        public void Alarm()
        {
            AlarmCalled = true;
        }
    }
}
