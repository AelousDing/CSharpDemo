using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Mediator_Pattern
{
    internal class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
