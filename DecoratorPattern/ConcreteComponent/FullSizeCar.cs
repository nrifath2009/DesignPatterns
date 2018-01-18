using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class FullSizeCar:Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }
        public override string GetCarDescription() => Description;
        
        public override double GetCarPrice() => 30000;

    }
}
