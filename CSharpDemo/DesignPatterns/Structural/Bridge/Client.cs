using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Bridge
{
    internal class Client
    {
        public void Main()
        {
            Abstraction abstraction=new RedefineAbstraction();
            abstraction.Opration();
        }
    }
}
