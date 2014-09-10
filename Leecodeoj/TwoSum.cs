//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/two-sum/</reference>
//----------------------------------------------------------------------

//  Given an array of integers, find two numbers such that they add up to a specific target number.
//  
//    The function twoSum should return indices of the two numbers such that they add up to the target, 
//    where index1 must be less than index2. Please note that your returned answers 
//    (both index1 and index2) are not zero-based.
//    
//    You may assume that each input would have exactly one solution.
//    
//    Input: numbers={2, 7, 11, 15}, target=9
//    Output: index1=1, index2=2

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Leecodeoj
{
    /// <summary>
    /// Two Sum 
    /// </summary>
    public class TwoSum
    {
        /// <summary>
        /// find two numbers such that they add up to a specific target number.
        /// </summary>
        /// <param name="inputNumbers">Given an array of integers</param>
        /// <param name="target">specific target number.</param>
        /// <returns>both index1 and index2 that sum is target</returns>
        public int[] findTwoSumIndex(int[] inputNumbers, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (dict.ContainsValue(target - inputNumbers[i]))
                {
                    result[0] = dict.Where(pair => pair.Value == (target - inputNumbers[i])).Select(pair => pair.Key).FirstOrDefault();
                    result[1] = i + 1;
                }
                dict.Add(i + 1, inputNumbers[i]);
            }
            return result;
        }

        public int[] findTwoSumIndex_BigONxN(int[] inputNumbers, int target)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] + inputNumbers[j] == target)
                        return new int[]{ i+1, j+1};
                }
            }
            return null;
        }
    }
}
