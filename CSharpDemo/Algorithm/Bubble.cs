using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo.Algorithm
{
    public class Bubble
    {
        public int[] BubbleSortAsc(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentNullException("arr");
            }
            if (arr.Length == 1)
            {
                return arr;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public int[] BubbleSortDesc(int[] arr)
        {
            if (arr == null || arr.Length <= 0)
            {
                throw new ArgumentNullException("arr");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
