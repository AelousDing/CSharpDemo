using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Visitor_Pattern
{
    internal abstract class Visitor
    {
        public abstract void VisitElement1(ConcreteElement1 concreteElement1);
        public abstract void VisitElement2(ConcreteElement2 concreteElement2);
    }
}
