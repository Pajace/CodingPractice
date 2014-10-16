//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference> https://oj.leetcode.com/problems/count-and-say/ </reference>
//----------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    public class CountAndSay
    {
        public string SayIt(int inputNumber)
        {
            string result = "1";
            for (int i = 0; i < inputNumber-1; i++)
                result = calculateNextSequence(result);

            return result;
        }

        private string calculateNextSequence(string inputString)
        {
            StringBuilder builder = new StringBuilder();
            
            char number = inputString[0];
            int count = 1;
            for (int i = 1; i < inputString.Count(); i++)
            {
                if (number == inputString[i])
                    count += 1;
                else
                {
                    builder.Append(count.ToString());
                    builder.Append(number);

                    count = 1;
                    number = inputString[i];
                }
            }

            builder.Append(count.ToString());
            builder.Append(number);

            return builder.ToString();
        }
    }
}
