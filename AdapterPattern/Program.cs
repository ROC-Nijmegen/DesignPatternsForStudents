using PondGame;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            // TODO: Create the Goose class and instantiate an object
            // Testing the turkey.
            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Flutter();

            // Testing the duck with the testDuck() method, which expects a Duck object
            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            // TODO: Wrap WildTurkey object in the TurkeyAdapter and store in Duck variable
            // Now let's test the turkey using the testDuck() method
            // (which still expects a Duck object)
            Console.WriteLine("The TurkeyAdapter says...");
            // TODO: Test the TurkeyAdapter instance using the TestDuck() method
            // TestDuck();

            // TODO: Create a Goose adapter class and implement accordingly
            // TODO: Wrap the Goose object in the Goose adapter
            // TODO: Test the Goose adapter instance using the TestDuck() method
        }

        // Method to get a duck to call its Quack() and Fly() methods
        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}