using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Decorator
{
    internal class Client
    {
        public void Main()
        {
            Component component = new ConcreteDecorator(new ConcreteComponent());
            component.Operation();
        }
    }
}
