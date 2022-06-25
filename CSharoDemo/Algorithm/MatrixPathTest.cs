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
    public class MatrixPathTest
    {
        char[][] matrix = new char[3][];

        [TestInitialize]
        public void Init()
        {
            matrix[0] = new char[] { 'a', 'b', 't', 'g' };
            matrix[1] = new char[] { 'c', 'f', 'c', 's' };
            matrix[2] = new char[] { 'j', 'd', 'e', 'h' };
        }
        [TestMethod]
        public void HasPath()
        {
            MatrixPath matrixPath = new MatrixPath();
            var hasPath = matrixPath.HasPath(matrix, 3, 4, "bfce");
            Assert.IsTrue(hasPath);
        }
    }
}
