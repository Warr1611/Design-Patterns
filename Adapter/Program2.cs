public void Main () {
    WildTurkey turkey = new WildTurkey();
    Duck turkeyAdapter = new TurkeyAdapter(turkey);

    turkeyAdapter.quack();
    turkeyAdapter.fly();
}