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
    public class MaxSubSequenceTest
    {
        int[] input = { 14, 4, -6, 32, -4, 5, 6, 6, 8, -76, 6, 74, 3, -24, 32, 43, 45, 57, -2, 42, 45, 45, 65, 8, 79, -6, 65, 35, -3, 53, -42, 3, 2, 3 };
        [TestMethod]
        public void Sum()
        {
            MaxSubSequence maxSubSequence = new MaxSubSequence();
            int sum = maxSubSequence.Sum(input);
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void Sum1()
        {
            MaxSubSequence maxSubSequence = new MaxSubSequence();
            int sum = maxSubSequence.Sum1(input);
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void Sum2()
        {
            MaxSubSequence maxSubSequence = new MaxSubSequence();
            int sum = maxSubSequence.Sum2(input);
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void Sum3()
        {
            MaxSubSequence maxSubSequence = new MaxSubSequence();
            int sum = maxSubSequence.Sum3(input);
            Console.WriteLine(sum);
        }
    }
}
