using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request";
        }
    }
}
