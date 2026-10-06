using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage tallEspresso = new Espresso(Size.TALL);
            PrintBeverage(tallEspresso);
            Beverage grandeEspresso = new Espresso(Size.GRANDE);
            PrintBeverage(grandeEspresso); 
            Beverage ventiEespresso = new Espresso(Size.VENTI);
            PrintBeverage(ventiEespresso);

            Beverage lungo = new Espresso(Size.TALL);
            lungo = new Water(lungo);
            PrintBeverage(lungo);


            Beverage americano = new Espresso(Size.VENTI);
            americano = new Water(americano);
            americano = new Water(americano);
            americano = new Mocha(americano);
            americano = new Whip(americano);
            PrintBeverage(americano);

            // TODO: Instantiate each required beverage from the list from the assignment
            // TODO: Test each instance with the PrintBeverage() function

        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}