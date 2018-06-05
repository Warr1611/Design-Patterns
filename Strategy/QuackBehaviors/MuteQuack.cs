public class Mute : IQuackBehavior {
    public override void quack() {
        Console.WriteLine("<< Silence >>");
    }
}