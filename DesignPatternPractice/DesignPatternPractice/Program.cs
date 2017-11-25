using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternPractice.DecoratorPattern;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Decorator Pattern
            Pizza pizza = new GreenSaucePizza();
            pizza = new Cheese(pizza);
            pizza = new Cheese(pizza);

            Console.WriteLine($"Name:{pizza.GetName()},Cost:{pizza.GetCost()}");
            Console.ReadLine();
        }
    }
}
