using System;
using InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor;
using InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models;
using InformationSystemsEngineering.Patterns._4.AbstractFactoryAndBuilder;
using InformationSystemsEngineering.Patterns.InversionOfControl.FactoryMethod;
using InformationSystemsEngineering.Patterns.ObserverIterator.Iterator;
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

            #region Iterator
            
            var collection = new TransportCollection<string>();
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

            #region VisitorIterator

            var cars = new TransportCollection<CarModel>
            {
                new CarModel() {CarName = "#1", CarСondition = "OK", CarWeight = 1000},
                new CarModel() {CarName = "#2", CarСondition = "OK", CarWeight = 1200},
                new CarModel() {CarName = "#3", CarСondition = "NOT OK", CarWeight = 1250}
            };
            var trucks = new TransportCollection<TruckModel>
            {
                new TruckModel() {TruckName = "#1", TruckСondition = "NOT OK", TruckWeight = 5000},
                new TruckModel() {TruckName = "#2", TruckСondition = "NOT OK", TruckWeight = 7200},
                new TruckModel() {TruckName = "#3", TruckСondition = "NOT OK", TruckWeight = 7250}
            };
            
            var weightChecker = new WeightChecker();
            var conditionChecker = new СonditionChecker();
            
            foreach (CarModel? car in cars)
            {
                car?.AcceptVisitor(weightChecker);
                car?.AcceptVisitor(conditionChecker);
            }
            
            foreach (TruckModel? truck in trucks)
            {
                truck?.AcceptVisitor(weightChecker);
                truck?.AcceptVisitor(conditionChecker);
            }

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

            #region FactoryMethod

            var cocaCola = new CocaColaFactory().CreateProduct();
            var pepsi = new PepsiFactory().CreateProduct();
            
            Console.WriteLine($"Pepsi: ");
            pepsi.Drink();
            Console.WriteLine("CocaCola: ");
            cocaCola.Drink();

            #endregion

            #region AbstractFactoryAndBuilder

            IVehiclesFactory carFactory = new MercedesFactory();
            carFactory.CreateCar();
            carFactory.CreateTruck();
            
            carFactory = new VolvoFactory();
            carFactory.CreateCar();
            carFactory.CreateTruck();

            #endregion
        }
    }
}