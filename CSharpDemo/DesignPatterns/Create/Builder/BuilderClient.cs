using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.Builder
{
    public class BuilderClient
    {
        public static void Run()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full feature product:");
            director.BuildFullFeatureProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());
        }
    }
}
