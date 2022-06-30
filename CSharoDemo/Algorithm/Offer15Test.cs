using CSharpDemo.Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharoDemo.Algorithm
{
    [TestClass]
    public class Offer15Test
    {
        [TestMethod]
        public void NumberOf1_IsOk()
        {
            Offer15 offer15 = new Offer15();
            int count = offer15.NumberOf1(10);//10 二进制1010
            Assert.AreEqual(2, count);
        }
    }
}
