using InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models;

namespace InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor
{
    public interface ICarVisitor
    {
        public void Visit(CarModel carModel);
        public void Visit(TruckModel truckModel);
    }
}