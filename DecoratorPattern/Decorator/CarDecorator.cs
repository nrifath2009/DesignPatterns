using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public class CarDecorator:Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override string GetCarDescription() => _car.GetCarDescription();

        public override double GetCarPrice() => _car.GetCarPrice();

    }
}
