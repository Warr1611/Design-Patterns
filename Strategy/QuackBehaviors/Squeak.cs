using System;

namespace Strategy
{
    public class Squeak : IQuackBehavior {
        public void quack() {
            Console.WriteLine("Squeak");
        }
    }
}