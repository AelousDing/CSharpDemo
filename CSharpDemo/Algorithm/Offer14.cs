using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    /// <summary>
    /// 剪绳子
    /// </summary>
    public class Offer14
    {
        #region 动态规划方法
        public int MaxMultiple(int length)
        {
            if (length < 2)
            {
                return 0;
            }
            else if (length == 2)
            {
                return 1;
            }
            else if (length == 3)
            {
                return 2;
            }
            int[] results = new int[length + 1];
            results[0] = 0;
            results[1] = 1;
            results[2] = 2;
            results[3] = 3;
            int max = 0;
            int result = 0;
            for (int i = 4; i <= length; i++)
            {
                max = 0;
                for (int j = 0; j <= i / 2; j++)
                {
                    result = results[j] * results[i - j];
                    if (result > max)
                    {
                        max = result;
                    }
                }
                results[i] = max;
            }
            return results[length];
        }
        #endregion

        #region 贪婪方法
        public int MaxMultiple1(int length)
        {
            if (length < 2)
            {
                return 0;
            }
            else if (length == 2)
            {
                return 1;
            }
            else if (length == 3)
            {
                return 2;
            }
            int timesOf3 = length / 3;
            if (length - timesOf3 * 3 == 1)
            {
                timesOf3 -= 1;
            }
            int timesOf2 = (length - timesOf3 * 3) / 2;
            return (int)(Math.Pow(3, timesOf3) * Math.Pow(2, timesOf2));
        }
        #endregion
    }
}
