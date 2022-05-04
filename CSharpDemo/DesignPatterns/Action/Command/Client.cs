using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Command
{
    internal class Client
    {
        public void Main()
        {
            Reciever reciever = new Reciever();
            ConcreteCommand concreteCommand = new ConcreteCommand(reciever);
        }
    }
}
