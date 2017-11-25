using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.DecoratorPattern
{
    public class GreenSaucePizza : Pizza
    {
        public GreenSaucePizza()
        {
            base._name = "青醬Pizza";
        }

        public override decimal GetCost()
        {
            return 350;
        }
    }
}
