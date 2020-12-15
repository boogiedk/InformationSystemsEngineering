using System;

namespace InformationSystemsEngineering.Patterns._4.AbstractFactoryAndBuilder
{
    public class VolvoFactory : IVehiclesFactory
    {
        public Car CreateCar()
        {
            Console.WriteLine("Volvo car is created.");
            return new Car()
            {
                Name = "Volvo Car #2",
                Model = "12"
            };
        }

        public Truck CreateTruck()
        {
            Console.WriteLine("Volvo truck is created.");
            return new Truck()
            {
                Name = "Volvo Truck #2",
                Model = "2"
            };
        }
    }
}