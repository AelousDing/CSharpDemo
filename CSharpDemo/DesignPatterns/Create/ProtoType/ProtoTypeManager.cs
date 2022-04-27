using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpDemo.DesignPatterns.Create.ProtoType
{
    internal class ProtoTypeManager
    {
        Dictionary<string, ProtoType> protoTypes = new Dictionary<string, ProtoType>();

        public void Add(string key, ProtoType protoType)
        {
            if (protoTypes.Keys.Contains(key))
            {
                protoTypes[key] = protoType;
            }
            else
            {
                protoTypes.Add(key, protoType);
            }
        }
        public ProtoType GetProtoType(string key)
        {
            protoTypes.TryGetValue(key, out var protoType);
            return protoType;
        }
    }
}
