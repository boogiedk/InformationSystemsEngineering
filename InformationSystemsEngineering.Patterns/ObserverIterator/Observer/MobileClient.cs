using System;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Observer
{
    class MobileClient : IObserver
    {
        public void Update(NotificationServiceObserver notificationServiceObserver)
        {            
            if (notificationServiceObserver.State == 3)
            {
                Console.WriteLine("MobileClient: Получил уведомление");
            }
        }
    }
}