using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    abstract class RequestHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        
        public virtual IRequestResult Handle(IRequestModel request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}