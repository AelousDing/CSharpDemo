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
    public class BubbleTest
    {
        int[] input = new int[] { 1, 4, 3, 7, 4, 9, 325, 87, 65, 22 };
        int[] inputNull = null;
        int[] inputNullOne = new int[] { 1 };
        [TestMethod]
        public void BubbleSortDesc()
        {
            Bubble bubble = new Bubble();
            bubble.BubbleSortDesc(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        [TestMethod]
        public void BubbleSortDesc_Null()
        {
            Bubble bubble = new Bubble();
            try
            {
                bubble.BubbleSortDesc(inputNull);
                foreach (var item in input)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsNull(inputNull);
            }
        }
        [TestMethod]
        public void BubbleSortDesc_One()
        {
            Bubble bubble = new Bubble();
            try
            {
                bubble.BubbleSortDesc(inputNullOne);
                foreach (var item in inputNullOne)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void BubbleSortAsc()
        {
            Bubble bubble = new Bubble();
            bubble.BubbleSortAsc(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        [TestMethod]
        public void BubbleSortAsc_Null()
        {
            Bubble bubble = new Bubble();
            try
            {
                bubble.BubbleSortAsc(inputNull);
                foreach (var item in input)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsNull(inputNull);
            }
        }
        [TestMethod]
        public void BubbleSortAsc_One()
        {
            Bubble bubble = new Bubble();
            try
            {
                bubble.BubbleSortAsc(inputNullOne);
                foreach (var item in inputNullOne)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
