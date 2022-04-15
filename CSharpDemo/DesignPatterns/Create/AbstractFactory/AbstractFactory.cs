using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.AbstractFactory
{
    public class AbstractFactory
    {
        public virtual AbstractProductA CreateProductA()
        {
            throw new NotImplementedException();
        }
        public virtual AbstractProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}
