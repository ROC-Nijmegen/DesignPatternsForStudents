namespace SimpleFactoryToAbstract
{
    internal class Program
    {
        // This code serves as an example for the Factory Method Pattern.
        static void Main(string[] args)
        {
            /* This time, instead of making a seperate factory class and pass it as an argument,
             * we instantiate a specific child class of a pizza store to give us a specific pizza.
             */
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza.Name);

            // TODO: Create a new ChicagoPizzaStore child class
            // TODO: Create the required ChicagoStyle pizza child classes
            // TODO: Instantiate a ChicagoPizzaStore and order a "cheese" pizza
        }
    }
}