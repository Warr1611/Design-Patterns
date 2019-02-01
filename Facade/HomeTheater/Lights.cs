using System;

namespace Facade
{
    public class Lights {
        public void dim() {
            Console.WriteLine("Dim lights...");
        }

        public void on() {
            Console.WriteLine("Lights on...");
        }
    }
}