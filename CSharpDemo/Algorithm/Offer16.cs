using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Algorithm
{
    public class Offer16
    {
        public bool invalideInput = false;
        public double Power(double baseValue, int exponent)
        {
            if (baseValue.Equals(0.0) && exponent < 0)
            {
                return 0;
            }
            int absExponent = exponent;
            if (exponent < 0)
                absExponent = -exponent;
            double result = PowerWithUnsignedExponent(baseValue, absExponent);
            if (exponent < 0)
            {
                result = 1.0 / result;
            }
            return result;
        }

        private double PowerWithUnsignedExponent(double baseValue, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            if (exponent == 1)
            {
                return baseValue;
            }
            double result = PowerWithUnsignedExponent(baseValue, exponent >> 1);
            result *= result;
            if ((exponent & 0x01) == 1)
            {
                result *= baseValue;
            }
            return result;
        }
    }
}
