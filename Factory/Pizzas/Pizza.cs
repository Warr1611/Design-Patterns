public abstract class Pizza {
    string name;
    string dough;
    string sauce;
    List<string> toppings = new List<string>();

    void prepare() {
        Console.WriteLine("Preparing...");
    }

    void bake() {
        Console.WriteLine("Baking...");
    }

    void cut() {
        Console.WriteLine("Cutting into triangles...");
    }

    void box() {
        Console.WriteLine("Boxing...");
    }

    public string getName() {
        return name;
    }
}