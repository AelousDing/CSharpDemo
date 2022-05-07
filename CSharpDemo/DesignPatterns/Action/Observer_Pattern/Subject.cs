using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Observer_Pattern
{
    internal class Subject
    {
        List<Observer> observers;
        public void Attach(Observer observer)
        {
            if (observers == null)
            {
                observers = new List<Observer>();
            }
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            if (observer == null)
            {
                return;
            }
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Upadate(this);
            }
        }
    }
}
