using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class RevolesArrayMin
    {
        /// <summary>
        /// arr 是升序旋转的数组
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int Min(int[] arr)
        {
            if (arr == null || arr.Count() < 2)
            {
                throw new ArgumentException("arr");
            }
            int left = 0;
            int right = arr.Length - 1;
            int mid = left;
            while (arr[left] >= arr[right])
            {
                if (right - left == 1)
                {
                    break;
                }
                mid = (left + right) / 2;

                if (arr[left] == arr[mid] && arr[mid] == arr[right])
                {
                    return MinInOrder(arr, left, right);
                }

                if (arr[left] <= arr[mid])
                {
                    left = mid;
                }
                else
                {
                    right = mid;
                }
            }
            return arr[right];
        }

        private int MinInOrder(int[] arr, int left, int right)
        {
            int result = arr[left];
            for (int i = left + 1; i < right; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
            }
            return result;
        }
    }
}
