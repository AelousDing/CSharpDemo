using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Facade
{
    internal class Client
    {
        public void Main()
        {
            Facade.Instance.Operation();
        }
    }
}
