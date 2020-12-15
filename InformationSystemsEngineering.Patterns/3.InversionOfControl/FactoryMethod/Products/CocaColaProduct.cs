using System;

namespace InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod.Products
{
    public class CocaColaProduct : IProduct
    {
        public void Drink()
        {
            Console.WriteLine("Drunk!");
        }
    }
}