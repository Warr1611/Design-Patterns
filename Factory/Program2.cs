public static void Main() {
    PizzaStore nyStore = new NYPizzaStore();
    Pizza Store chicagoStore = new ChicagoPizzaStore();

    Pizza pizza = nyStore.orderPizza("cheese");
    Console.WriteLine("Ethan ordered a " + pizza.getName());

    pizza = chicagoStore.orderPizza("cheese");
    Console.WriteLine("Joel ordered a " + pizza.getName());    
}