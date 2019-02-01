namespace Decorator
{
    public abstract class CondimentDecorator : Beverage {
        public Beverage beverage;
        public abstract new string getDescription();

        public new Size getSize() {
            return beverage.getSize();
        }
    }
}