using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Memento_Pattern
{
    internal class Origintor
    {
        State state;
        public Memento CreateMemento()
        {
            return new Memento();
        }
        public void SetMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}
