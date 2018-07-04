public abstract class CaffeineBeverageWithHook {
    final void prepareRecipe() { // determines a template to follow
        boilWater();
        brew();
        pourInCup();
        if (customerWantsCondiments()) {
            addCondiments();
        }
    }

    abstract void brew();

    abstract void addCondiments();

    void boilWater() {
        Console.WriteLine("Boiling water");
    }

    void pourInCup() {
        Console.WriteLine("Pouring into cup");
    }

    bool customerWantsCondiments() { // subclasses can override the hook
        return true;
    }
}