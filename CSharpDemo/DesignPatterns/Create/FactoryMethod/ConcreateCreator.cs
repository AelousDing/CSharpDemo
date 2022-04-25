using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.FactoryMethod
{
    internal class ConcreateCreator : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreateProduct();
        }
    }
}
