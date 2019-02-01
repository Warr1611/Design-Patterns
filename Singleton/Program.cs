using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler = ChocolateBoiler.getInstance();
            boiler.fill();   
        }
    }
}
