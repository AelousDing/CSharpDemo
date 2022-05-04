using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Command
{
    internal class ConcreteCommand : Command
    {
        Reciever reciever;
        public ConcreteCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public override void Execute()
        {
            reciever.Action();
        }
    }
}
