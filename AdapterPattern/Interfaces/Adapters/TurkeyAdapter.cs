using PondGame;

namespace AdapterPattern
{
    internal class TurkeyAdapter : Duck
    {
        // TODO: Add adaptee component
        // TODO: Add constructor that accepts the adaptee component as argument
        public TurkeyAdapter() 
        {
        }

        // TODO: Correctly implement corresponding method
        public override void Quack()
        {
            // TODO: Turkey should "Quack" here
        }

        // TODO: Correctly implement corresponding method
        public override void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                // TODO: TUrkey should "Fly" here
            }
        }
    }
}
