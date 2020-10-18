using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        IRequestResult Handle(IRequestModel request);
    }
}