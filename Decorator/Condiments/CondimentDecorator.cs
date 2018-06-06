public abstract class CondimentDecorator : Beverage {
    public Beverage beverage;
    public abstract string getDescription();

    public Size getSize() {
        return beverage.getSize();
    }
}