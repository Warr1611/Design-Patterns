using System;

namespace Template
{
    public abstract class CaffeineBeverageWithHook {
        public void prepareRecipe() { // determines a template to follow
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments()) {
                addCondiments();
            }
        }

        protected abstract void brew();

        protected abstract void addCondiments();

        void boilWater() {
            Console.WriteLine("Boiling water");
        }

        void pourInCup() {
            Console.WriteLine("Pouring into cup");
        }

        bool customerWantsCondiments() { // subclasses can override the hook
            return true;
        }
    }
}