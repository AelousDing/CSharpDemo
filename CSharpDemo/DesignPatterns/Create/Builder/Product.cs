using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.Builder
{
    public class Product
    {
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Product parts:" + str + "\n";
        }
    }
}
