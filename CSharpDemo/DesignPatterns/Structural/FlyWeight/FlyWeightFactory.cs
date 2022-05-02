using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.DesignPatterns.Structural.FlyWeight
{
    internal class FlyWeightFactory
    {
        List<FlyWeight> flyWeightList = new List<FlyWeight>();
        public FlyWeight CreateFlyWeight(string flag)
        {
            if (!Contains(flag))
            {
                //创建对应的享元对象，并添加到集合里面
                return null;
            }
            //返回对应的享元对象
            return null;
        }
        /// <summary>
        /// 判断对应的享元是否已经存在
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Contains(string flag)
        { 
            throw new NotImplementedException();
        }
    }
}
