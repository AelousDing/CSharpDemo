using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Observer_Pattern
{
    internal class ConcreteObserver : Observer
    {
        ConcreteSubject concreteSubject;
        public ConcreteObserver(ConcreteSubject concreteSubject)
        {
            this.concreteSubject = concreteSubject;
        }
        public override void Upadate(Subject subject)
        {
            concreteSubject.GetSubjectState();
        }
    }
}
