using System;
using System.Diagnostics.SymbolStore;
using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    class RequestValidatorHandler : RequestHandler
    {
        public override IRequestResult Handle(IRequestModel request)
        {
            Console.WriteLine("RequestValidator");
            Console.WriteLine($"{(request != null && request.Id != Guid.Empty ? " OK " : " BAD ")}");

            if (request == null || request.Id == Guid.Empty)
            {
                SetNext(null);
            }

            return base.Handle(request);
        }
    }
}