using System;

namespace InformationSystemsEngineering.Patterns._4.AbstractFactoryAndBuilder
{
    public class MercedesFactory : IVehiclesFactory
    {
        public Car CreateCar()
        {
            Console.WriteLine("Mercedes car is created.");
            return new Car()
            {
                Name = "Mercedes Car #1",
                Model = "1"
            };
        }

        public Truck CreateTruck()
        {
            Console.WriteLine("Mercedes truck is created.");
            return new Truck()
            {
                Name = "Mercedes Truck #1",
                Model = "1"
            };
        }
    }
}