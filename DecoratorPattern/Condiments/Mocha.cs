using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage, "Mocha")
        {
        }

        public override double cost()
        {
            return 0.20 + (baseBeverage?.cost() ?? 0);
        }

    }
}
