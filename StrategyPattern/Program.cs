using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            // TODO: Create an instance of RobotDuck


            // Test all instances of Duck using the testDuck() method
            // TODO: Test ALL the instances
            testDuck(mallardDuck);
            testDuck(redheadDuck);
            testDuck(decoyDuck);
            testDuck(rubberDuck);
            // TODO: Change the behaviour of a Duck on the fly and test
        }

        private static void testDuck(Duck duck)
        {
            duck.PerformFly();
            duck.PerformQuack();
            // TODO: Test the PerformSwim() method
        }
    }
}