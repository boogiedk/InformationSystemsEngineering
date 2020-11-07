using System;

namespace InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod.Products
{
    public class PepsiProduct : IProduct
    {
        public void Drink()
        {
            Console.WriteLine("Drunk!");
        }
    }
}