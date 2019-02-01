namespace Decorator
{
    public class Mocha : CondimentDecorator {
        Beverage beverage;

        public Mocha(Beverage beverage) {
            this.beverage = beverage;
        }

        public override string getDescription() {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost() {
            double cost = beverage.cost();
            Size size = beverage.getSize();
            switch (size) {
                case Size.TALL:
                    cost += .15;
                    break;
                case Size.GRANDE:
                    cost += .20;
                    break;
                case Size.VENTI:
                    cost += .25;
                    break;            
            }
            return cost;
        }
    }
}