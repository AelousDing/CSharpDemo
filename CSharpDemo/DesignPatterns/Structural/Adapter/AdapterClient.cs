using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Adapter
{
    public class AdapterClient
    {
        public static void Run()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client");
            Console.WriteLine("But with adpter client can call it is method");
            Console.WriteLine(target.GetRequest());
        }
    }
}
