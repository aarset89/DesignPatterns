using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.Mediator
{
    public abstract class UIControl
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)=> _observers.Add(observer);
        protected void NotifyObservers()
        {
            foreach(Observer observer in _observers)
                observer.Update();
        }
    }
}
