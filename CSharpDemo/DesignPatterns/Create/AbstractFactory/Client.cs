using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    internal class Client
    {
        public void Run()
        {
            AbstractFactory factory = new ConcreteFactory1();//此处是变化量，可以根据情况选用配置等方式隔离出来
            factory.CreateProductA().GetA();
            factory.CreateProductB().GetB();
        }
    }
}
