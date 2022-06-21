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
    public class RevolesArrayMinTest
    {
        int[] input = new int[] { 3, 4, 5, 1, 2 };
        [TestMethod]
        public void Sum()
        {
            RevolesArrayMin revolesArrayMin = new RevolesArrayMin();
            int min = revolesArrayMin.Min(input);
            Console.WriteLine(min);
        }
    }
}
