using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallanges
{
    public static class NumberHelper
    {
        public static bool IsArmstrong(int number)
        {
            int b, sum = 0;
            int numberToCheck = number;
            while (numberToCheck > 0)
            {
                b = numberToCheck % 10;
                sum += (b * b * b);
                numberToCheck /= 10;
            }
            return number == sum;
        }
    }
}
