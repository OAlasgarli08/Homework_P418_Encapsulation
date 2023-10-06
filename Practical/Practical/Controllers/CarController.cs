using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controllers
{
    internal class CarController
    {
        public void ExampleForCars()
        {
            
            Car car = new();

            car.colour = "red";

            car.speed = 500;

            car.Vin = "dooos";

            Console.WriteLine(car.Vin);
        }

    }
}
