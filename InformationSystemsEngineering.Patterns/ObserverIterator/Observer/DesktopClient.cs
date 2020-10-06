using System;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Observer
{
    class DesktopClient : IObserver
    {
        public void Update(NotificationServiceObserver notificationServiceObserver)
        {
            if (notificationServiceObserver.State == 2)
            {
                Console.WriteLine("DesktopClient: Получил уведомление");
            }
        }
    }
}