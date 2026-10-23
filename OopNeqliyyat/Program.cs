using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopNeqliyyat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car { Brand = "BMW", Speed = 220 });
            vehicles.Add(new Motorcycle { Brand = "Yamaha", Speed = 180 });
            vehicles.Add(new Bicycle { Brand = "Giant", Speed = 30 });

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Brand: {vehicle.Brand}, Speed: {vehicle.Speed}");
                vehicle.MakeSound();
            }

        }
    }
}
