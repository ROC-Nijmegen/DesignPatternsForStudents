namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        // TODO: Create components of all required Behaviours
        public abstract void Display();

        public void PerformQuack()
        {
            // TODO: Call corresponding behaviour method
        }

        public void PerformFly()
        {
            // TODO: Call corresponding behaviour method
        }
        public void Swim()
        {
            // TODO: Call corresponding behaviour method
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
