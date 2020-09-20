using System;
using InformationSystemsEngineering.Patterns.TemplateMethod;
using InformationSystemsEngineering.Patterns.TemplateMethod.Models;
using InformationSystemsEngineering.Patterns.TemplateMethod.Validators;

namespace InformationSystemsEngineering.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region TemplateMethod

            // json
            
            var jsonValidator = new Validator<JsonRequestModel>(new JsonValidator());

            var jsonRequest = new JsonRequestModel
            {
                Id = Guid.NewGuid(),
                Title = "Json title",
                Content = "Json content"
            };

            jsonValidator.Validate(jsonRequest);
            
            Console.WriteLine();
            
            // xml

            var xmlValidator = new Validator<XmlRequestModel>(new XmlValidator());
            
            var xmlRequest = new XmlRequestModel
            {
                Id = Guid.NewGuid(),
                Title = "Xml title",
                Content = "Xml content"
            };
            
            xmlValidator.Validate(xmlRequest);
            
            Console.WriteLine();
            
            #endregion
        }
    }
}