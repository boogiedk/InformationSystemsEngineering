using System;
using System.Collections.Generic;
using InformationSystemsEngineering.Patterns.ChainOfCommand.Models;

namespace InformationSystemsEngineering.Patterns.ChainOfCommand
{
    class Client
    {
        public static void ClientCode(IHandler handler)
        {
            var requests = new List<IRequestModel>
            {
                new RequestRegisterModel
                {
                    Title = "Title34343",
                    Content = "Contentdsfsdf",
                    Id = Guid.NewGuid()
                },
                new RequestRegisterModel
                {
                    Title = "Titlesdfsfs",
                    Content = "Content222232",
                    Id = Guid.NewGuid()
                },
                new RequestRegisterModel
                {
                    Title = "TEST",
                    Id = Guid.NewGuid()
                },
                new RequestRegisterModel(),
                null
            };
            
            foreach (var requestModel in requests)
            {
                Console.WriteLine($"Client: Validate request with title: {requestModel?.Title ?? "empty"} and content: {requestModel?.Content ?? "empty"}.");

                handler.Handle(requestModel);
            }
        }
    }
}