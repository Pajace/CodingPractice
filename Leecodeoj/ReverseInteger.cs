//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/reverse-integer/</reference>
//----------------------------------------------------------------------

namespace Leecodeoj
{
    public class ReverseInteger
    {
        public int reverse_solution2(int inputNumber)
        {
            bool isNegative = false;
            if (inputNumber < 0) { 
                isNegative = true;
                inputNumber *= -1;
            }

            int result = 0;
            while (true)
            {
                int digit = inputNumber % 10;
                result = result * 10 + digit;
                inputNumber /= 10;
                if (inputNumber == 0)
                    break;
            }

            if (isNegative)
                result *= -1;

            return result;
        }
    }
}
