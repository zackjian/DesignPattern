using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.DecoratorPattern
{
    public abstract class IngredientsDecorator : Pizza
    {
        public abstract override string GetName();
    }
}
