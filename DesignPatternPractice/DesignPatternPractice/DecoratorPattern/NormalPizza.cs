using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.DecoratorPattern
{
    public class NormalPizza : Pizza
    {
        public NormalPizza()
        {
            base._name = "一般Pizza";
        }

        public override decimal GetCost()
        {
            return 200;
        }
    }
}
