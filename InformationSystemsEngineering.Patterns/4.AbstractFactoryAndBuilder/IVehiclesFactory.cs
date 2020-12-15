namespace InformationSystemsEngineering.Patterns._4.AbstractFactoryAndBuilder
{
    public interface IVehiclesFactory
    {
        public Car CreateCar();
        public Truck CreateTruck();
    }
}