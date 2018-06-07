public class NYPizzaStore : PizzaStore {

    public Pizza createPizza(string type) {
        switch (type) {
            case "cheese":
                return new NYStyleCheesePizza();
            default:
                return new NYStyleCheesePizza();
        }
    }
}