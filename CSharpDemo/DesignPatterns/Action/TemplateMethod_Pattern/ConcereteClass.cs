using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.TemplateMethod_Pattern
{
    internal class ConcereteClass : AbsctractClass
    {
        protected override void PrimitiveOperation1()
        {
            throw new NotImplementedException();
        }

        protected override void PrimitiveOperation2()
        {
            throw new NotImplementedException();
        }
    }
}
