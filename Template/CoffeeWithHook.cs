using System;

namespace Template
{
    public class CoffeeWithHook : CaffeineBeverageWithHook {
        protected override void brew() {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void addCondiments() {
            Console.WriteLine("Adding sugar and milk");
        }

        public bool customerWantsCondiments() {
            string answer = "y";

            if (string.Equals(answer, "y")) {
                return true;
            }
            else {
                return false;
            }
        }    
    }
}