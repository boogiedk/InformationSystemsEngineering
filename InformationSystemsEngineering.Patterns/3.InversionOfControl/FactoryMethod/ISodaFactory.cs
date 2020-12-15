using InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod.Products;

namespace InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod
{
    public interface ISodaFactory
    {
        public IProduct CreateProduct();
    }
}