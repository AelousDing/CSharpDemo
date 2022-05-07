using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.Memento_Pattern
{
    internal class Memento
    {
        State state;
        public State GetState()
        {
            return state;
        }
        public void SetState(State state)
        {
            this.state = state;
        }
    }
}
