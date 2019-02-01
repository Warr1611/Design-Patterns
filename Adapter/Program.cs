namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            turkeyAdapter.quack();
            turkeyAdapter.fly();
        }
    }
}
