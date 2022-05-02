using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Decorator
{
    internal class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("装饰器在不使用继承，不修改类的情况下添加的新功能");
        }
    }
}
