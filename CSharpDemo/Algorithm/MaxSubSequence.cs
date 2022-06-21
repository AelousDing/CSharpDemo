using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class MaxSubSequence
    {
        /// <summary>
        /// 暴力方法  时间复杂度O(N^3) 不推荐使用
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public int Sum(int[] sequence)
        {
            if (sequence == null || sequence.Length <= 0)
            {
                return 0;
            }
            int length = sequence.Length;
            int maxSum = 0, subSum = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    subSum = 0;
                    for (int k = i; k < j; k++)
                    {
                        subSum += sequence[k];
                    }
                    if (subSum > maxSum)
                    {
                        maxSum = subSum;
                    }
                }
            }
            return maxSum;
        }
        /// <summary>
        /// 暴力方法  时间复杂度O(N^2) 不推荐使用
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public int Sum1(int[] sequence)
        {
            if (sequence == null || sequence.Length <= 0)
            {
                return 0;
            }
            int length = sequence.Length;
            int maxSum = 0, subSum = 0;
            for (int i = 0; i < length; i++)
            {
                subSum = 0;
                for (int j = i; j < length; j++)
                {
                    subSum += sequence[j];
                    if (subSum > maxSum)
                    {
                        maxSum = subSum;
                    }
                }
            }
            return maxSum;
        }
        /// <summary>
        /// 分治法 时间复杂度O(nlogn) 
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public int Sum2(int[] sequence)
        {
            return BinarySum(sequence, 0, sequence.Length - 1);
        }
        private int BinarySum(int[] sequence, int left, int right)
        {
            if (left > right)
            {
                return 0;
            }
            if (left == right)
            {
                return sequence[left];
            }
            int mid = (left + right) / 2;
            int leftSum = 0;
            int leftMax = 0;
            for (int i = mid; i >= left; i--)
            {
                leftSum += sequence[i];
                if (leftSum > leftMax)
                {
                    leftMax = leftSum;
                }
            }
            int rightSum = 0;
            int rightMax = 0;
            for (int i = mid + 1; i < right; i++)
            {
                rightSum += sequence[i];
                if (rightSum > rightMax)
                {
                    rightMax = rightSum;
                }
            }
            return max3(leftMax + rightMax, BinarySum(sequence, left, mid), BinarySum(sequence, mid + 1, right));
        }
        private int max3(int a, int b, int c)
        {
            int max1 = max2(a, b);
            return max2(max1, c);
        }
        private int max2(int a, int b)
        {
            return a > b ? a : b;
        }

        public int Sum3(int[] sequence)
        {
            if (sequence == null || sequence.Length <= 0)
            {
                return 0;
            }
            int maxSum = sequence[0];
            int sum = sequence[0];
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sum <= 0)
                {
                    sum = sequence[i];
                }
                else
                {
                    sum += sequence[i];
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }
    }
}
