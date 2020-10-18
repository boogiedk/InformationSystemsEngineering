using System;
using System.Diagnostics.SymbolStore;
using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    class ContentValidatorHandler : RequestHandler
    {
        public override IRequestResult Handle(IRequestModel request)
        {
            if (request != null)
            {
                Console.WriteLine("ContentValidator");
                Console.WriteLine($"{(!string.IsNullOrEmpty(request.Content) ? " OK " : " BAD ")}");
            }
            
            return base.Handle(request);
        }
    }
}