namespace Decorator
{
    public class Whip : CondimentDecorator {
        Beverage beverage;

        public Whip(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string getDescription() {
            return beverage.getDescription() + ", Whip";
        }

        public override double cost() {
            double cost = beverage.cost();
            Size size = beverage.getSize();
            switch (size) {
                case Size.TALL:
                    cost += .05;
                    break;
                case Size.GRANDE:
                    cost += .10;
                    break;
                case Size.VENTI:
                    cost += .15;
                    break;            
            }
            return cost;
        }
    }
}