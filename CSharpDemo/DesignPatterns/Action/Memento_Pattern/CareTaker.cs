using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Memento_Pattern
{
    internal class CareTaker
    {
        Origintor origintor;
        public CareTaker(Origintor origintor)
        {
            this.origintor = origintor;
        }
        public void Execute()
        {
            origintor.CreateMemento();
        }

        public void UnExecute()
        {
            //origintor.SetMemento();
        }
    }
}
