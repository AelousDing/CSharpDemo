using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
