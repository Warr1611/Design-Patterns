namespace Decorator
{
    public class DarkRoast : Beverage {

        public DarkRoast() {
            description = "Dark Roast";
        }

        public override double cost() {
            return .99;
        }
    }
}