using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Bridge
{
    internal class Abstraction
    {
        private Implementor implementor;
        public virtual void Opration()
        {
            implementor.OprationBase();
        }
    }
}
