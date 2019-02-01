namespace Decorator
{
    public class Decaf : Beverage {

        public Decaf() {
            description = "Decaf";
        }

        public override double cost() {
            return 1.05;
        }
    }
}