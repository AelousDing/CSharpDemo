using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.Builder
{
    public class Director
    {
        private IBuilder builder;
        public IBuilder Builder
        {
            set
            {
                builder = value;
            }
        }
        public void BuildMinimalViableProduct()
        {
            this.builder.BuildPartA();
        }
        public void BuildFullFeatureProduct()
        {
            this.builder.BuildPartA();
            this.builder.BuildPartB();
            this.builder.BuildPartC();
        }
    }
}
