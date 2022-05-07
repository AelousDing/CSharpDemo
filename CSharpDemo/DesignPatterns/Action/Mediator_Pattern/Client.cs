using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Mediator_Pattern
{
    internal class Client
    {
        public void Main()
        {
            Mediator mediator = new ConcreteMediator();
            Colleague colleague = new ConcreteColleague(mediator);
        }
    }
}
