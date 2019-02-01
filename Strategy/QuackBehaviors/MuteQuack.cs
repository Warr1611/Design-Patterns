using System;

namespace Strategy
{
    public class MuteQuack : IQuackBehavior {
        public void quack() {
            Console.WriteLine("<< Silence >>");
        }
    }
}