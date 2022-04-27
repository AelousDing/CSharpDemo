using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.ProtoType
{
    internal class Client
    {
        public Client(ProtoType ProtoType)
        {
            this.ProtoType = ProtoType;
        }
        ProtoType ProtoType;
        public void Main()
        {
            ProtoType.Clone();
        }
    }
}
