using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class SelectSort
    {
        public int[] SelectAsc(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentException("arr");
            }
            int minIndex;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                if (i != minIndex)
                {
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
            return arr;
        }
        public int[] SelectDesc(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentException("arr");
            }
            int maxIndex;
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[maxIndex] < arr[j])
                    {
                        maxIndex = j;
                    }
                }
                if (i != maxIndex)
                {
                    temp = arr[i];
                    arr[i] = arr[maxIndex];
                    arr[maxIndex] = temp;
                }
            }
            return arr;
        }
    }
}
