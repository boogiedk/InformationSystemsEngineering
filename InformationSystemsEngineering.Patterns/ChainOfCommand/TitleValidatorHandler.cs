using System;
using System.Diagnostics.SymbolStore;
using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    class TitleValidatorHandler : RequestHandler
    {
        public override IRequestResult Handle(IRequestModel request)
        {
            if (request != null)
            {
                Console.WriteLine("TitleValidator");
                Console.WriteLine($"{(!string.IsNullOrEmpty(request.Title) ? " OK " : " BAD ")}");
            }
            
            return base.Handle(request);
        }
    }
}