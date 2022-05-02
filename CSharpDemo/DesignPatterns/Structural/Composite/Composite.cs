using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Composite
{
    public class Composite : Component
    {
        private List<Component> components;

        public override void Add(Component component)
        {
            if (components == null)
            {
                components = new List<Component>();
            }

            components.Add(component);
        }
        public override void Remove(Component component)
        {
            if (components != null)
            {
                components.Remove(component);
            }
        }
    }
}
