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
    public class QuickSortTest
    {
        int[] input = new int[] { 1, 4, 3, 7, 4, 9, 325, 87, 65, 22 };
        [TestMethod]
        public void SortAsc()
        {
            QuickSort sort = new QuickSort();
            sort.SortAsc(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
