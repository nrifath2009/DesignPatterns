using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class LeatherSeats:CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetCarDescription() => $"{_car.GetCarDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;

    }
}
