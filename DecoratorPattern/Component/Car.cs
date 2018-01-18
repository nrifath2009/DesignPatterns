using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetCarDescription();
        public abstract double GetCarPrice();

    }
}
