﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.PushStyle
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer) => _observers.Add(observer);
        public void RemoveObserver(Observer observer) => _observers.Remove(observer);

        public void Notifyobservers(int value)
        {
            foreach (var observer in _observers)
                observer.Update(value);
        }

    }
}
