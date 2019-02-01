using System;

namespace Adapter
{
    public class WildTurkey : Turkey {
        public void gobble() {
            Console.WriteLine("Gobble gobble");
        }

        public void fly() {
            Console.WriteLine("Flying a short distance");
        }
    }
}