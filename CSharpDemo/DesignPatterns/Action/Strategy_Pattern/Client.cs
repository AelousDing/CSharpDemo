using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Strategy_Pattern
{
    internal class Client
    {
        public void Main()
        {
            ConcreteStrategy1 concreteStrategy1 = new ConcreteStrategy1();
            Context context = new Context(concreteStrategy1);
            context.ContextInterface();
        }
    }
}
