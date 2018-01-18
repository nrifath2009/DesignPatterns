using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar =new LeatherSeats(theCar);
            theCar = new Navigation(theCar);
            theCar = new SunRoof(theCar);
            Console.WriteLine(theCar.GetCarDescription());
            Console.WriteLine($"{theCar.GetCarPrice():C2}");
            Console.ReadKey();
        }
    }
}
