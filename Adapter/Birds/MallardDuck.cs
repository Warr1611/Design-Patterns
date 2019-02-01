using System;

namespace Adapter
{
    public class MallardDuck : Duck {
        public void quack() {
            Console.WriteLine("Quack");
        }

        public void fly() {
            Console.WriteLine("I'm flying!");
        }
    }
}