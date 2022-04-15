using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    public class ProductB1 : AbstractProductB
    {
        public override void GetB()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
