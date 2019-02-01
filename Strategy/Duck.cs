using System;

namespace Strategy
{
    public class Duck {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void performQuack() {
            quackBehavior.quack();
        }

        public void performFly() {
            flyBehavior.fly();
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior) {
            this.quackBehavior = quackBehavior;
        }

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }
    }
}