//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/palindrome-number/</reference>
//----------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int inputNumber)
        {
            if (inputNumber < 0)
                return false;

            int digitCount = 0;
            int temp = inputNumber;
            while (temp > 0)
            {
                temp /= 10;
                digitCount++;
            }

            int loop_times = digitCount / 2;

            for (int i = 0; i < loop_times; i++)
            {
                int highDigit = (inputNumber / (int)Math.Pow(10, digitCount - (i + 1))) % 10;
                int lowDigit = (inputNumber % (int)Math.Pow(10, i + 1)) / (int)Math.Pow(10, i);

                if (highDigit != lowDigit)
                    return false;
            }

            return true;
        }
    }
}
