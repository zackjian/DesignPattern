using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.DecoratorPattern
{
    public class Cheese : IngredientsDecorator
    {
        /// <summary>
        /// Pizza
        /// </summary>
        private Pizza _pizza;

        public Cheese(Pizza pizza)
        {
            this._pizza = pizza;
        }

        public override decimal GetCost()
        {
            return this._pizza.GetCost() + 10;
        }

        public override string GetName()
        {
            return this._pizza.GetName() + "+ 起司";
        }
    }
}
