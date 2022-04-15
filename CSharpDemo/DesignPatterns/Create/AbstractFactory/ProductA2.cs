using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    public class ProductA2 : AbstractProductA
    {
        public override void GetA()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
