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
    public class Offer16Test
    {
        [TestMethod]
        public void Power_Positive()
        {
            Offer16 offer16 = new Offer16();
            double result = offer16.Power(2, 2);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void Power_0()
        {
            Offer16 offer16 = new Offer16();
            double result = offer16.Power(2, 0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Power_Negative()
        {
            Offer16 offer16 = new Offer16();
            double result = offer16.Power(2, -2);
            Assert.AreEqual(0.25, result);
        }
    }
}
