using InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod.Products;

namespace InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod
{
    public class PepsiFactory : ISodaFactory
    {
        public IProduct CreateProduct()
        {
            return new PepsiProduct();
        }
    }
}