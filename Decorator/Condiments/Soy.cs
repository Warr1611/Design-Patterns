public class Soy : CondimentDecorator {
    Beverage beverage;

    public Soy(Beverage beverage) {
        beverage = beverage;
    }

    public string getDescription() {
        return beverage.getDescription() + ", Soy";
    }

    public double cost() {
        return beverage.cost() + .15;
    }
}