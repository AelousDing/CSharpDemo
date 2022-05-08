using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Visitor_Pattern
{
    internal class Client
    {
        public void Main()
        {
            ConcreteVisitor1 concreteVisitor1 = new ConcreteVisitor1();

            ConcreteElement1 concreteElement1 = new ConcreteElement1();
            concreteElement1.Accept(concreteVisitor1);
        }
    }
}
