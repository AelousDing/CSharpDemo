using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.ProtoType
{
    internal class ProtoType
    {
        public virtual ProtoType Clone()
        {
            throw new NotImplementedException();//缺省拷贝
        }
    }
}
