public class Soy : CondimentDecorator {
    Beverage beverage;

    public Soy(Beverage beverage) {
        beverage = beverage;
    }

    public string getDescription() {
        return beverage.getDescription() + ", Soy";
    }

    public double cost() {
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