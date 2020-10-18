using System;
using InformationSystemsEngineering.Patterns.ChainOfCommand;
using InformationSystemsEngineering.Patterns.ObserverIterator.Iterator;
using InformationSystemsEngineering.Patterns.ObserverIterator.Observer;
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

            #region Iterator
            
            var collection = new NotificationCollection<string>();
            collection.Add("Dog");
            collection.Add("Cat");
            collection.Add("Duck");

            Console.WriteLine("Animals: ");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse animals:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            #endregion

            #region ObserverIterator
            
            var notificationService = new NotificationServiceObserver();
            var mobileClient = new MobileClient();
            notificationService.Attach(mobileClient);

            var desktopClient = new DesktopClient();
            notificationService.Attach(desktopClient);

            notificationService.ChangeState(2);
            notificationService.ChangeState(3);

            notificationService.Detach(desktopClient);

            notificationService.ChangeState(2);

            #endregion

            #region ChainOfCommand
            
            var requestValidator = new RequestValidatorHandler();
            var titleValidator = new TitleValidatorHandler();
            var contentValidator = new ContentValidatorHandler();

            Console.WriteLine("Chain of validate");
            
            requestValidator
                .SetNext(titleValidator)
                .SetNext(contentValidator);
            
            Console.WriteLine();

            #endregion
        }
    }
}