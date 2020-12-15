using System;
using InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models;

namespace InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor
{
    public class WeightChecker : ICarVisitor
    {
        public void Visit(CarModel carModel)
        {
            Console.WriteLine($"Car {carModel.CarName} Weight:{carModel.CarWeight}.");
        }

        public void Visit(TruckModel truckModel)
        {
            Console.WriteLine($"Truck {truckModel.TruckName} Weight:{truckModel.TruckWeight}.");
        }
    }
}