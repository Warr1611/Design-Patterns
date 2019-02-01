using System;

namespace Strategy
{
    public class FlyRocketPowered : IFlyBehavior {
        public void fly() {
            Console.WriteLine("I'm flying with a rocket!'");
        }
    }
}