using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.ChainOfResponsibility
{
    internal class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(Handler handler) : base(handler)
        {
        }
    }
}
