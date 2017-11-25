using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.DecoratorPattern
{
    public abstract class Pizza
    {
        public string _name = "";

        public virtual string GetName()
        {
            return this._name;
        }

        public abstract decimal GetCost();
            
    }
}
