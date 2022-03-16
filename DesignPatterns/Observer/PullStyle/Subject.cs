using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PullStyle
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer) => _observers.Add(observer);
        public void RemoveObserver(Observer observer) => _observers.Remove(observer);

        public void Notifyobservers()
        {
            foreach (var observer in _observers)
                observer.Update();
        }

    }
}
