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
    public class MergeSortTest
    {
        List<int> input = new List<int> { 1, 4, 3, 7, 4, 9, 325, 87, 65, 22 };
        [TestMethod]
        public void SortAsc()
        {
            MergeSort mergeSort = new MergeSort();
            var result= mergeSort.SortAsc(input);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
