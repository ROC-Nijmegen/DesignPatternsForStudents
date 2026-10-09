namespace SimpleFactory
{
    internal class Program
    {
        // This code serves as an example to create a simplistic factory for a store.
        static void Main(string[] args)
        {
            // If I wanted to create New York pizza's, I Instantiate NYFactory and pass it to my PizzaStore.
            NYPizzaFactory nyFactory = new NYPizzaFactory();
            PizzaStore nyStore = new PizzaStore(nyFactory);
            nyStore.OrderPizza("Veggie");

            // If I wanted to create Chicago pizza's, I instantiate a ChicagoFactory and pass it to my PizzaStore.
            ChicagoPizzaFactory chicagoFactory = new ChicagoPizzaFactory();
            PizzaStore chicagoStore = new PizzaStore(chicagoFactory);
            chicagoStore.OrderPizza("Veggie");
        }
    }
}