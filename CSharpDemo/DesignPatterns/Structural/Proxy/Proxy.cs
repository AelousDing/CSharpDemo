using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Proxy
{
    internal class Proxy : Subject
    {
        RealSubject realSubject;
        public override void Request()
        {
            realSubject.Request();
        }

        public RealSubject GetSubject()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            return realSubject;
        }
    }
}
