using System;
using InformationSystemsEngineering.Patterns.TemplateMethod.Models;

namespace InformationSystemsEngineering.Patterns.TemplateMethod.Validators
{
    public class JsonValidator : BaseRequestValidator<JsonRequestModel>
    {
        public override void ValidateTitle(JsonRequestModel requestModel)
        {
            Console.WriteLine($"The title in JSON model is validated. Title = {requestModel.Title} \n");
        }

        public override void ValidateContent(JsonRequestModel requestModel)
        {
            Console.WriteLine($"The content in JSON model is validated. Content = {requestModel.Content} \n");
        }
    }
}