using System;
using InformationSystemsEngineering.Patterns.TemplateMethod.Models;

namespace InformationSystemsEngineering.Patterns.TemplateMethod.Validators
{
    public class XmlValidator : BaseRequestValidator<XmlRequestModel>
    {
        public override void ValidateTitle(XmlRequestModel requestModel)
        {
            Console.WriteLine($"The title in XML model is validated. Title = {requestModel.Title} \n");
        }

        public override void ValidateContent(XmlRequestModel requestModel)
        {
            Console.WriteLine($"The content in XML model is validated. Content = {requestModel.Content} \n");
        }
    }
}