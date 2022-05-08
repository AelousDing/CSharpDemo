using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.TemplateMethod_Pattern
{
    internal abstract class AbsctractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
        }
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }
}
