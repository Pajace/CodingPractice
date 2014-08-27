//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/single-number/</reference>
//----------------------------------------------------------------------

using System;
using System.Linq;

namespace Leecodeoj
{
    /// <summary>
    /// Given an array of integers, every element appears twice except for one. Find that single one.
    /// Note:
    /// Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
    /// </summary>
    public static class SingleNumber
    {
        public static int SolutionXOR(int[] A)
        {
            int result = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                result = result ^ A[i];
            }
            return result;
        }

        public static int SolutionSortFirst(int[] A)
        {
            Array.Sort(A);
            int result = -1;

            Boolean isFirstHit = true;
            for (int i = 0; i < A.Length; i++)
            {
                if (isFirstHit)
                {
                    result = A[i];
                    isFirstHit = false;
                }
                else
                {
                    if (result == A[i])
                        isFirstHit = true;
                    else
                        break;
                }
            }

            return result;
        }
    }
}
