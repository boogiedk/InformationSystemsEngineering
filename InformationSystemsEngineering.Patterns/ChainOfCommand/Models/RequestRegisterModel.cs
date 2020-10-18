using System;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand.Models
{
    public class RequestRegisterModel : IRequestModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid Id { get; set; }
    }
}