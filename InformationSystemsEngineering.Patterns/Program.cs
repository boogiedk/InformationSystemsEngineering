using System;
using InformationSystemsEngineering.Patterns.Strategy;
using InformationSystemsEngineering.Patterns.Strategy.Services;
using InformationSystemsEngineering.Patterns.TemplateMethod;
using InformationSystemsEngineering.Patterns.TemplateMethod.Models;
using InformationSystemsEngineering.Patterns.TemplateMethod.Validators;

namespace InformationSystemsEngineering.Patterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region TemplateMethod

            // json
            
            var jsonValidator = new Validator<JsonRequestModel>(new JsonValidator());

            var jsonRequest = new JsonRequestModel
            {
                Id = Guid.NewGuid(),
                Title = "Json title",
                Content = "Json content"
            };

            jsonValidator.Validate(jsonRequest);
            
            Console.WriteLine();
            
            // xml

            var xmlValidator = new Validator<XmlRequestModel>(new XmlValidator());
            
            var xmlRequest = new XmlRequestModel
            {
                Id = Guid.NewGuid(),
                Title = "Xml title",
                Content = "Xml content"
            };
            
            xmlValidator.Validate(xmlRequest);
            
            Console.WriteLine();
            
            #endregion

            #region Strategy
            
            var context = new Context();
            
            // course schedule
            var courseScheduleService = new CourseScheduleService();

            context.ScheduleService = courseScheduleService;

            var courseSchedule = context.Get();

            Console.WriteLine(courseSchedule.Content);

            // exam schedule
            var examScheduleService = new ExamScheduleService();

            context.ScheduleService = examScheduleService;

            var examSchedule = context.Get();
            
            Console.WriteLine(examSchedule.Content);

            #endregion
        }
    }
}