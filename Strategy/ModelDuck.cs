public class ModelDuck : Duck {
    // Can dynamically set its behaviors
    public ModelDuck(FlyBehavior fb, QuackBehavior qb) {
        quackBehavior = qb;
        flyBehavior = fb;
    }

    // Can change its behaviors at runtime
    public void setFlyBehavior(FlyBehavior fb) {
        flyBehavior = fb;
    }
    public void setQuackBehavior(QuackBehavior qb) {
        quackBehavior = qb;
    }
}