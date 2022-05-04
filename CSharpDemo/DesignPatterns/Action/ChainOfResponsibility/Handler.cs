using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Action.ChainOfResponsibility
{
    internal class Handler
    {
        protected Handler handler = null;
        public Handler(Handler handler)
        {
            this.handler = handler;
        }
        public virtual void Request()
        {
            if (handler != null)
            {
                handler.Request();
            }
        }
    }
}
