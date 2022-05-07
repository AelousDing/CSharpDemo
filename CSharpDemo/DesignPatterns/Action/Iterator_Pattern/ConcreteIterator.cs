using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Iterator_Pattern
{
    internal class ConcreteIterator : Iterator<int>
    {
        public ConcreteIterator(ConcreteAggeregate concreteAggeregate)
        {

        }
        public int Current()
        {
            throw new NotImplementedException();
        }

        public void First()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }
    }
}
