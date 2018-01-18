using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class CompactCar:Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override string GetCarDescription() => Description;

        public override double GetCarPrice() => 10000;


    }
}
