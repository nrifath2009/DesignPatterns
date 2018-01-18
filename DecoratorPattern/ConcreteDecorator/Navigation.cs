using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Navigation:CarDecorator
    {
        
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override string GetCarDescription() => $"{_car.GetCarDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 5000;

    }
}
