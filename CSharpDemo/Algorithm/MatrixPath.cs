using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class MatrixPath
    {
        #region 剑指offer 面试题12
        public bool HasPath(char[][] matrix, int rows, int colums, string str)
        {
            if (matrix == null || rows < 1 || colums < 1 || string.IsNullOrEmpty(str))
            {
                return false;
            }
            bool[][] visited = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[colums];
                for (int j = 0; j < colums; j++)
                {
                    visited[i][j] = false;
                }
            }
            int pathLength = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (HasPathCore(matrix, rows, colums, i, j, pathLength, str, visited))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private bool HasPathCore(char[][] matrix, int rows, int colums, int row, int column, int pathLength, string str, bool[][] visited)
        {
            if (str.Count() - 1 == pathLength)
            {
                return true;
            }
            bool hasPath = false;
            if (row >= 0 && row < rows
                && column >= 0 && column < colums
                && matrix[row][column] == str[pathLength]
                && !visited[row][column])
            {
                pathLength++;
                visited[row][column] = true;

                hasPath = HasPathCore(matrix, rows, colums, row, column - 1, pathLength, str, visited)
                    || HasPathCore(matrix, rows, colums, row - 1, column, pathLength, str, visited)
                    || HasPathCore(matrix, rows, colums, row, column + 1, pathLength, str, visited)
                    || HasPathCore(matrix, rows, colums, row + 1, column, pathLength, str, visited);
                if (!hasPath)
                {
                    pathLength--;
                    visited[row][column] = false;
                }
            }
            return hasPath;
        }
        #endregion

        #region 剑指offer 面试题13
        public int MovingCount(int threshold, int rows, int columns)
        {
            if (threshold < 0 || rows <= 0 || columns <= 0)
            {
                return 0;
            }
            bool[] visited = new bool[rows * columns];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = false;
            }
            int count = MovingCountCore(threshold, rows, columns, 0, 0, visited);
            return count;
        }
        private int MovingCountCore(int threshold, int rows, int columns, int row, int column, bool[] visited)
        {
            int count = 0;
            if (Check(threshold, rows, columns, row, column, visited))
            {
                visited[row * columns + column] = true;
                count = 1
                    + MovingCountCore(threshold, rows, columns, row, column - 1, visited)
                    + MovingCountCore(threshold, rows, columns, row - 1, column, visited)
                    + MovingCountCore(threshold, rows, columns, row + 1, column, visited)
                    + MovingCountCore(threshold, rows, columns, row, column + 1, visited);
            }
            return count;
        }
        private bool Check(int threshold, int rows, int columns, int row, int column, bool[] visited)
        {
            if (row >= 0 && row < rows
                && column >= 0 && column < columns
                && GetDigitSum(row) + GetDigitSum(column) <= threshold
                && !visited[row * columns + column])
            {
                return true;
            }
            return false;
        }
        private int GetDigitSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion
    }
}
