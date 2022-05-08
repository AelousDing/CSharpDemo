using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.TemplateMethod_Pattern
{
    internal class Client
    {
        public void Main()
        {
            AbsctractClass absctractClass = new ConcereteClass();
            absctractClass.TemplateMethod();
        }
    }
}
