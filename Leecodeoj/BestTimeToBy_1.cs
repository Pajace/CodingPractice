//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/best-time-to-buy-and-sell-stock/</reference>
//----------------------------------------------------------------------

// Problem: Best Time to By in Stock I
// Say you have an array for which the i-th element is the price of a given stock on day i.
// If you were only permitted to complete at most one transaction (i.e, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
using System;
namespace Leecodeoj
{
    public class BestTimeToBy_1
    {
        /// <summary>
        /// get the maxProfit at most one transaction
        /// </summary>
        /// <param name="prices">Input prices</param>
        /// <returns>maxProfit</returns>
        public int maxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;
            int maxProfit = 0;

            int minPrice = prices[0];
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                int pridictProfit = prices[i] - minPrice;
                if (pridictProfit > maxProfit)
                    maxProfit = pridictProfit;
            }

            return maxProfit;
        }
    }
}
