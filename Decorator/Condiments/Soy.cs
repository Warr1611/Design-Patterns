namespace Decorator
{
    public class Soy : CondimentDecorator {
        Beverage beverage;

        public Soy(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string getDescription() {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost() {
            double cost = beverage.cost();
            Size size = beverage.getSize();
            switch (size) {
                case Size.TALL:
                    cost += .10;
                    break;
                case Size.GRANDE:
                    cost += .15;
                    break;
                case Size.VENTI:
                    cost += .20;
                    break;            
            }
            return cost;
        }
    }
}