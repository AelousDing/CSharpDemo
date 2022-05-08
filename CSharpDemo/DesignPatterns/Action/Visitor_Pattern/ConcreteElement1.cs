using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Visitor_Pattern
{
    internal class ConcreteElement1 : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElement1(this);
        }
    }
}
