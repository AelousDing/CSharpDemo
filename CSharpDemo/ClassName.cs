using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    public class ClassName
    {
        public string TypeName()
        {
            return this.GetType().Name;
        }
    }
    public class ClassNameChildren : ClassName
    {
        public static void Run()
        {
            ClassNameChildren classNameChildren = new ClassNameChildren();
            Console.WriteLine(classNameChildren.TypeName());
        }
    }
}
