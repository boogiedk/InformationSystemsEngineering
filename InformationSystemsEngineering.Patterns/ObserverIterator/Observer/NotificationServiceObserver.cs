using System;
using System.Collections.Generic;
using System.Threading;
using InformationSystemsEngineering.Patterns.ObserverIterator.Iterator;

namespace InformationSystemsEngineering.Patterns.ObserverIterator.Observer
{
    public class NotificationServiceObserver
    {
        public int State { get; set; } = -0;
        
        private NotificationCollection<IObserver> _observers = new NotificationCollection<IObserver>();
        
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Сервис: Наблюдатель добавлен.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Сервис: Наблюдатель удален.");
        }
        
        public void Notify()
        {
            Console.WriteLine("Сервис: Отправляются уведомления наблюдателям.");

            foreach (var observer in _observers)
            {
                (observer as IObserver).Update(this);
            }
        }
        
        public void ChangeState(int newState)
        {
            State = newState;

            Console.WriteLine("Сервис: Статус сменен на " + this.State);
            
            Notify();
        }
    }
}