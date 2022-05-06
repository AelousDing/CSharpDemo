using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Iterator_Pattern
{
    internal class ConcreteAggeregate : Aggregate<int>
    {
        public Iterator<int> CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
