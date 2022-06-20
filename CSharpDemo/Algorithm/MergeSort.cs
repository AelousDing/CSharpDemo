using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class MergeSort
    {
        public List<int> SortAsc(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            int mid = list.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < mid; i++)
            {
                left.Add(list[i]);
            }
            for (int i = mid; i < list.Count; i++)
            {
                right.Add(list[i]);
            }
            left = SortAsc(left);
            right = SortAsc(right);
            return Merge(left, right);
        }
        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] < right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            if (left.Count > 0)
            {
                for (int i = 0; i < left.Count; i++)
                {
                    result.Add(left[i]);
                }
            }
            if (right.Count > 0)
            {
                for (int i = 0; i < right.Count; i++)
                {
                    result.Add(right[i]);
                }
            }
            return result;
        }
    }
}
