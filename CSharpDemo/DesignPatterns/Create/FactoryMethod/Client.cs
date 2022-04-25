using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.FactoryMethod
{
    internal class Client
    {
        public void Main()
        {
            Creator creator = new ConcreateCreator();
            Product product = creator.CreateProduct();
        }
    }
}
