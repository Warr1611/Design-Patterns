public class ChicagoPizzaStore : PizzaStore {

    public Pizza createPizza(string type) {
        switch (type) {
            case "cheese":
                return new ChicagoStyleCheesePizza();
            default:
                return new ChicagoStyleCheesePizza();
        }
    }
}