using System;

namespace Strategy
{
    public class FlyWithWings : IFlyBehavior {
        public void fly() {
            Console.WriteLine("I'm flying!!");
        }
    }
}