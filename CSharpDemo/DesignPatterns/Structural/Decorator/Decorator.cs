using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Decorator
{
    internal class Decorator : Component
    {
        protected Component component;
        public Decorator(Component component)
        {
            this.component = component;
        }
    }
}
