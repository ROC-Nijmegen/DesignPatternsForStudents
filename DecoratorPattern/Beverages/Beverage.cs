using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENTI
    }
    internal abstract class Beverage
    {
        public Size Size 
        { 
            get { return size; } 
        }
        private Size size;
        protected string description = "Unknown";
        public Beverage(string description, Size size)
        {
            this.description = description;
            this.size = size;
        }

        public virtual string GetDescription()
        {
            return description;
        }

        // TODO: Implement Size calculations for each beverage and condiment
        public abstract double cost();
    }
}
