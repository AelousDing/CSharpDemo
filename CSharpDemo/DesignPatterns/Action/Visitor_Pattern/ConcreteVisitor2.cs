using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Visitor_Pattern
{
    internal class ConcreteVisitor2 : Visitor
    {
        public override void VisitElement1(ConcreteElement1 concreteElement1)
        {
            throw new NotImplementedException();
        }

        public override void VisitElement2(ConcreteElement2 concreteElement2)
        {
            throw new NotImplementedException();
        }
    }
}
