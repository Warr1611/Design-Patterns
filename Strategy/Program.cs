using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            // No fly, mute
            Duck model = new ModelDuck(new FlyNoWay(), new MuteQuack());
            model.performQuack();
            model.performFly();

            // Change at runtime to quack and fly rocket powered
            model.setQuackBehavior(new Quack());
            model.setFlyBehavior(new FlyRocketPowered());
            model.performQuack();
            model.performFly();
        }
    }
}
