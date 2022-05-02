using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Decorator
{
    internal class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("组件本身具有的功能");
        }
    }
}
