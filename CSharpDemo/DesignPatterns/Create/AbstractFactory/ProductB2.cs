using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    public class ProductB2 : AbstractProductB
    {
        public override void GetB()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
