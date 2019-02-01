namespace Strategy
{
    public class ModelDuck : Duck {
        // Can dynamically set its behaviors
        public ModelDuck(IFlyBehavior fb, IQuackBehavior qb) {
            quackBehavior = qb;
            flyBehavior = fb;
        }

        // Can change its behaviors at runtime
        public void setFlyBehavior(IFlyBehavior fb) {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb) {
            quackBehavior = qb;
        }
    }
}