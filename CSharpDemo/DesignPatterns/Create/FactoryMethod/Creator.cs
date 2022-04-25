using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.FactoryMethod
{
    internal abstract class Creator
    {
        public abstract Product CreateProduct();
    }
}
