namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        public abstract void Display();

        public void PerformQuack()
        {
        }

        public void PerformFly()
        {
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
