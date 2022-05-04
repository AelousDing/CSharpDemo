using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.ChainOfResponsibility
{
    internal class Client
    {
        public void Main()
        {
            ConcreteHandler1 handler1 = new ConcreteHandler1();
            ConcreteHandler2 handler2 = new ConcreteHandler2(handler1);
            handler2.Request();
        }
    }
}
