using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Create.Singleton
{
    internal class Singleton
    {
        public readonly static object SingletonLock = new object();
        protected Singleton()
        {

        }
        private Singleton instance;

        public Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SingletonLock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
