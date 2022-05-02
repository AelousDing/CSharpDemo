using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.Facade
{
    internal class Facade
    {
        readonly static object objLock = new object();
        private static Facade instance;
        //通常Facade模式类是单例
        public static Facade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (objLock)
                    {
                        if (instance == null)
                        {
                            instance = new Facade();
                        }
                    }
                }
                return instance;
            }
        }

        private SubSystemClass1 subSystemClass1 = new SubSystemClass1();
        private SubSystemClass2 subSystemClass2 = new SubSystemClass2();
        public void Operation()
        {
            subSystemClass1.SubSystemClass1Operation();
            subSystemClass2.SubSystemClass2Operation();
        }
    }
}
