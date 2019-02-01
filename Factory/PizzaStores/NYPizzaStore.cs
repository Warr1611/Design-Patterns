namespace Factory
{
    public class NYPizzaStore : PizzaStore {

        protected override Pizza createPizza(string type) {
            switch (type) {
                case "cheese":
                    return new NYStyleCheesePizza();
                default:
                    return new NYStyleCheesePizza();
            }
        }
    }
}