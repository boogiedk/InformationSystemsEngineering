using System;
using InformationSystemsEngineering.Patterns.TemplateMethod.Models;

namespace InformationSystemsEngineering.Patterns.TemplateMethod
{
    public abstract class BaseRequestValidator<T> where T: IRequestModel
    {
        public void Validate(T requestModel)
        {
            ValidateRequest(requestModel);
            ValidateTitle(requestModel);
            ValidateContent(requestModel);
        }

        public void ValidateRequest(T requestModel)
        {
            Console.WriteLine($"Validating a request is finished. Id = {requestModel.Id}\n");
        }

        public abstract void ValidateTitle(T requestModel);
        
        public abstract void ValidateContent(T requestModel);
    }
}