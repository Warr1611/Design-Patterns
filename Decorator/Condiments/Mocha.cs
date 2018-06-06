public class Mocha : CondimentDecorator {
    Beverage beverage;

    public Mocha(Beverage beverage) {
        beverage = beverage;
    }

    public string getDescription() {
        return beverage.getDescription() + ", Mocha";
    }

    public double cost() {
        return beverage.cost() + .20;
    }
}