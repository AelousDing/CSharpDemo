using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Composite
{
    public class Client
    {
        public void Main()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            Composite composite = new Composite();
            composite.Add(concreteComponent);
            composite.Operation();
        }
    }
}
