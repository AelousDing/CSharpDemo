using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Mediator_Pattern
{
    internal class ConcreteColleague : Colleague
    {
        public ConcreteColleague(Mediator mediator) : base(mediator)
        {
        }
    }
}
