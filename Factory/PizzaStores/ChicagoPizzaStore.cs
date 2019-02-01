namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore {

        protected override Pizza createPizza(string type) {
            switch (type) {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                default:
                    return new ChicagoStyleCheesePizza();
            }
        }
    }
}