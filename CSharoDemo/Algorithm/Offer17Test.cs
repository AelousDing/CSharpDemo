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
    public class Offer17Test
    {
        [TestMethod]
        public void Print1ToMaxOfNDigits_Positive()
        {
            Offer17 offer17 = new Offer17();
            offer17.Print1ToMaxOfNDigits(2);
        }
        [TestMethod]
        public void Print1ToMaxOfNDigits_Nagetive()
        {
            Offer17 offer17 = new Offer17();
            offer17.Print1ToMaxOfNDigits(-2);
        }
        [TestMethod]
        public void Print1ToMaxOfNDigits_0()
        {
            Offer17 offer17 = new Offer17();
            offer17.Print1ToMaxOfNDigits(0);
        }
    }
}
