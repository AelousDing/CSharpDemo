using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.State_Pattern
{
    internal class Context
    {
        State state;
        public Context(State state)
        {
            this.state = state;
        }
        public void ChangeState(State state)
        {
            this.state = state;
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
