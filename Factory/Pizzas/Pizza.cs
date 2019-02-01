using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void prepare() {
            Console.WriteLine("Preparing...");
        }

        public void bake() {
            Console.WriteLine("Baking...");
        }

        public void cut() {
            Console.WriteLine("Cutting into triangles...");
        }

        public void box() {
            Console.WriteLine("Boxing...");
        }

        public string getName() {
            return name;
        }
    }
}