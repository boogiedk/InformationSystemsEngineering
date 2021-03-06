using InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod.Products;

namespace InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod
{
    public class CocaColaFactory : ISodaFactory
    {
        public IProduct CreateProduct()
        {
            return new CocaColaProduct();
        }
    }
}