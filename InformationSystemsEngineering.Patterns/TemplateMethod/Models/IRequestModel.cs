using System;

namespace InformationSystemsEngineering.Patterns.TemplateMethod.Models
{
    public interface IRequestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}