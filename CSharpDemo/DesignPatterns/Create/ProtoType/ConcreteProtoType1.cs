using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.ProtoType
{
    internal class ConcreteProtoType1 : ProtoType
    {
        public override ProtoType Clone()
        {
            return base.Clone();//重写拷贝逻辑
        }
    }
}
