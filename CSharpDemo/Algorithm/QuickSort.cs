using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class QuickSort
    {
        public void SortAsc(int[] arr)
        {
            QuickSort1(arr, arr.Length, 0, arr.Length - 1);
        }
        private void QuickSort1(int[] data, int length, int start, int end)
        {
            //Console.WriteLine(string.Join(" ", data));
            if (start == end)
            {
                return;
            }
            int index = Partition(data, length, start, end);
            //Console.WriteLine($"index:{index}");
            if (index > start)
            {
                QuickSort1(data, length, start, index - 1);
            }
            if (index < end)
            {
                QuickSort1(data, length, index + 1, end);
            }
        }
        private int Partition(int[] data, int length, int start, int end)
        {
            Random random = new Random();
            int index = random.Next(start, end);
            Console.WriteLine($"index:{index}");
            int temp = data[index];
            data[index] = data[end];
            data[end] = temp;
            int small = start - 1;
            for (int i = start; i < end; i++)
            {
                if (data[i] < data[end])
                {
                    small++;
                    Console.WriteLine($"< small:{small} i:{i}");
                    if (i != small)
                    {
                        Console.WriteLine($"swap small:{small} i:{i}");
                        temp = data[i];
                        data[i] = data[small];
                        data[small] = temp;
                    }
                }
                Console.WriteLine($"small:{small} i:{i}");
            }
            small++;
            temp = data[small];
            data[small] = data[end];
            data[end] = temp;
            return small;
        }
    }
}
