using System;
using InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models;

namespace InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor
{
    public class СonditionChecker : ICarVisitor
    {
        public void Visit(CarModel carModel)
        {
            Console.WriteLine($"Car {carModel.CarName} Сondition:{carModel.CarСondition}.");
        }

        public void Visit(TruckModel truckModel)
        {
            Console.WriteLine($"Truck {truckModel.TruckName} Сondition:{truckModel.TruckName}.");
        }
    }
}