using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Iterator_Pattern
{
    internal interface Iterator<T>
    {
        public void First();
        public T Current();
        void Next();
        public bool IsDone();

    }
}
