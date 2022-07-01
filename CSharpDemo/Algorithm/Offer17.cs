using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class Offer17
    {
        public void Print1ToMaxOfNDigits(int n)
        {
            if (n <= 0)
            {
                return;
            }
            char[] number = new char[n];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = '0';
            }
            while (!Increment(number))
            {
                PrintNumber(number);
            }
        }

        private void PrintNumber(char[] number)
        {
            bool isBeginning0 = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (isBeginning0 && number[i] != '0')
                {
                    isBeginning0 = false;
                }
                if (!isBeginning0)
                {
                    Console.Write(number[i]);
                }
            }
            Console.WriteLine();
        }

        private bool Increment(char[] number)
        {
            bool isOverflow = false;
            int nTakeOver = 0;
            int length = number.Length;
            int sum = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                sum = number[i] - '0' + nTakeOver;
                if (i == length - 1)
                {
                    sum++;
                }
                if (sum >= 10)
                {
                    if (i == 0)
                    {
                        isOverflow = true;
                    }
                    else
                    {
                        nTakeOver = 1;
                        sum -= 10;
                        number[i] = (char)(sum + '0');
                    }
                }
                else
                {
                    number[i] = (char)(sum + '0');
                    break;
                }
            }
            return isOverflow;
        }
    }
}
