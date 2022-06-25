using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class MatrixPath
    {
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
    }
}
