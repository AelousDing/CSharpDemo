using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    public class ProductA1 : AbstractProductA
    {
        public override void GetA()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
