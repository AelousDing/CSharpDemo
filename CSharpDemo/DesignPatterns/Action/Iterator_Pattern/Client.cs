using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Iterator_Pattern
{
    internal class Client
    {
        public void Main()
        {
            //外部迭代
            ConcreteAggeregate concreteAggeregate = new ConcreteAggeregate();
            Iterator<int> iterator = new ConcreteIterator(concreteAggeregate);
            while (!iterator.IsDone())
            {
                iterator.Next();
            }


            //
            ConcreteAggeregate concrete=new ConcreteAggeregate();
            var it= concrete.CreateIterator();

            //it内循环
        }
    }
}
