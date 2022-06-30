using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDemo.Algorithm;

namespace CSharoDemo.Algorithm
{
    [TestClass]
    public class Offer14Test
    {
        int[] lengths = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        [TestMethod]
        public void MaxMultiple_IsOk()
        {
            Offer14 offer14 = new Offer14();
            foreach (var result in lengths)
            {
                Console.WriteLine(offer14.MaxMultiple(result));
            }
        }
        [TestMethod]
        public void MaxMultiple1_IsOk()
        {
            Offer14 offer14 = new Offer14();
            foreach (var result in lengths)
            {
                Console.WriteLine(offer14.MaxMultiple1(result));
            }
        }
    }
}
