using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Visitor_Pattern
{
    internal abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
