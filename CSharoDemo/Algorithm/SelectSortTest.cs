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
    public class SelectSortTest
    {
        int[] input = new int[] { 1, 4, 3, 7, 4, 9, 325, 87, 65, 22 };
        int[] inputNull = null;
        int[] inputNullOne = new int[] { 1 };
        [TestMethod]
        public void SelectAsc()
        {
            SelectSort selectSort = new SelectSort();
            selectSort.SelectAsc(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
        [TestMethod]
        public void SelectDesc()
        {
            SelectSort selectSort = new SelectSort();
            selectSort.SelectDesc(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
