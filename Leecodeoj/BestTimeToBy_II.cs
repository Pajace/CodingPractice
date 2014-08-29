//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/</reference>
//-----------------------------------------------------------------------

// Problem: 
// Say you have an array for which the i-th element is the price of a given stock on day i.
// Design an algorithm to find the maximum profit. You may complete as many transactions as you like 
// (i.e, buy one and sell one share of the stock multiple times). However, you may not engage in multiple 
// transactions at the same time (i.e, you must sell the stock before you buy again).


using System;
namespace Leecodeoj
{
    /// <summary>
    /// Best Time to Buy and Sell Stock II
    /// </summary>
    public class BestTimeToBy_II
    {
        /// <summary>
        /// Best Time to Buy and Sell Stock II
        /// </summary>
        /// <param name="prices">prices on days</param>
        /// <returns>max profit</returns>
        public int maxProfit(int[] prices)
        {
            if (prices.Length <= 1) return 0;

            int totalProft = 0;
            int minPrice = prices[0];
            foreach (var currentPrice in prices)
            {
                if (currentPrice < minPrice)
                    minPrice = currentPrice;
                int profit = currentPrice - minPrice;
                if (profit > 0)
                {
                    totalProft += profit;
                    minPrice = currentPrice;
                }
            }

            return totalProft;
        }
    }
}
