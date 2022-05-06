using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Iterator_Pattern
{
    internal interface Aggregate<T>
    {
        Iterator<T> CreateIterator();
    }
}
