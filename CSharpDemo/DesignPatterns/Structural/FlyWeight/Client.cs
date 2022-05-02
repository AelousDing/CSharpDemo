using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.FlyWeight
{
    internal class Client
    {
        public void Main()
        {
            FlyWeightFactory factory = new FlyWeightFactory();

            FlyWeight flyWeight = factory.CreateFlyWeight("");
            //对享元进行外部状态的处理
        }
    }
}
