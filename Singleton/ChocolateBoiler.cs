public class ChocolateBoiler {
    // Modified from the book for C# thread safety, reference: 
    // https://rubikscode.net/2017/06/11/different-ways-to-implement-singleton-in-net-and-make-people-hate-you-along-the-way/

    private bool is_empty;
    private bool is_boiled;

    private static readonly Lazy<ChocolateBoiler> uniqueInstance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

    private ChocolateBoiler() {
        is_empty = true;
        is_boiled = false;
    }

    public static ChocolateBoiler getInstance() {
        return uniqueInstance.Value;
    }

    public void fill() {
        if (is_boiled) {
            is_empty = false;
            is_boiled = false;
        }
    }
}