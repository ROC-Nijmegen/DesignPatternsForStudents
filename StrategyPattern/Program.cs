using StrategyPattern.Ducks;

namespace StrategyPattern
{
    internal class Program
    {
        // TODO: Create concrete Behaviour classes
        // TODO: Create new RobotDuck class 
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            //TODO: Create an instance of RobotDuck


            //TODO: Test ALL the instances of Duck using the testDuck() method
            testDuck(mallardDuck);
            testDuck(redheadDuck);
            testDuck(decoyDuck);
            testDuck(rubberDuck);
            // TODO: Change the behaviour of a Duck on the fly and test using the testDuck() method
        }

        private static void testDuck(Duck duck)
        {
            // TODO: Test ALL the behaviour methods
            duck.PerformFly();
            duck.PerformQuack();
        }
    }
}