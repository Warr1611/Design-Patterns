public class Whip : CondimentDecorator {
    Beverage beverage;

    public Whip(Beverage beverage) {
        beverage = beverage;
    }

    public string getDescription() {
        return beverage.getDescription() + ", Whip";
    }

    public double cost() {
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