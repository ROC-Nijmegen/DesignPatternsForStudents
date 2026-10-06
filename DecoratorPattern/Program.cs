using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso.Size = Size.VENTI;
            PrintBeverage(espresso);

            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);


            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            americano = new Mocha(americano);
            americano = new Whip(americano);
            americano.cost();
            PrintBeverage(americano);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}