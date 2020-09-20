using InformationSystemsEngineering.Patterns.TemplateMethod.Models;

namespace InformationSystemsEngineering.Patterns.TemplateMethod
{
    public class Validator<T> where T: IRequestModel
    {
        private readonly BaseRequestValidator<T> _baseRequestValidator;
        public Validator(BaseRequestValidator<T> baseRequestValidator)
        {
            _baseRequestValidator = baseRequestValidator;
        }
        
        public void Validate(T requestModel)
        {
            _baseRequestValidator.Validate(requestModel);
        }
    }
}