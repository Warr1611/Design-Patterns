public class CoffeeWithHook : CaffeineBeverageWithHook {
    public void brew() {
        Console.WriteLine("Dripping coffee through filter");
    }

    public void addCondiments() {
        Console.WriteLine("Adding sugar and milk");
    }

    public bool customerWantsCondiments() {
        string answer = "y";

        if (string.Equals(answer, "y")) {
            return true;
        }
        else {
            return false;
        }
    }    
}