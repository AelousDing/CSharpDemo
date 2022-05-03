using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public void Mian()
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
