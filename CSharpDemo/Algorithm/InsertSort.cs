using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class InsertSort
    {
        public int[] InsertAsc(int[] arr)
        {
            int temp;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }
        public int[] InsertDesc(int[] arr)
        {
            int temp;
            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < temp)
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = temp;  
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }
    }
}
