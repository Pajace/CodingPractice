//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/candy/</reference>
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    /// <summary>
    /// Problem
    ///   There are N children standing in a line. Each child is assigned a rating value.
    ///   You are giving candies to these children subjected to the following requirements:
    ///    - Each child must have at least one candy.
    ///    - Children with a higher rating get more candies than their neighbors.
    ///   What is the minimum candies you must give?
    /// </summary>
    public class Candy
    {
        public int calculateMinimunCandies(int[] ratings)
        {
            if (ratings == null || ratings.Length == 0)
                return 0;
            else if (ratings.Length == 1)
                return ratings.Length;
            else if (ratings.Length == 2)
                return 3;

            bool isAlwaysIncrease = true;
            int toatalCandies = 0;

            int[] candies = new int[ratings.Length];

            ForwardCheck(ratings, candies, ref isAlwaysIncrease);

            if (isAlwaysIncrease)
            {
                toatalCandies = ((1 + ratings.Length) * ratings.Length) / 2;
            }
            else
            {
                candies = BackwardCheck(ratings, candies, toatalCandies);
                toatalCandies = candies.Sum();
            }


            return toatalCandies;
        }

        private static int[] BackwardCheck(int[] ratings, int[] candies, int toatalCandies)
        {
            for (int i = ratings.Length - 1; i > 0; i--)
            {
                if (ratings[i] < ratings[i - 1] && candies[i] >= candies[i - 1])
                    candies[i - 1] = candies[i] + 1;
            }
            return candies;
        }

        private static int[] ForwardCheck(int[] ratings, int[] candies, ref bool isAlwaysIncrease)
        {
            candies[0] = 1;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    candies[i] = candies[i - 1] + 1;
                else
                {
                    candies[i] = 1;
                    isAlwaysIncrease = false;
                }
            }
            return candies;
        }
    }
}
