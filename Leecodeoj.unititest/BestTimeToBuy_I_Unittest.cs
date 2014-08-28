using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class BestTimeToBuy_I_Unittest
    {
        private void assertMaxProfit(int[] prices, int expectedMaxProfit)
        {
            BestTimeToBy_1 b = new BestTimeToBy_1();

            int actualMaxProfit = b.maxProfit(prices);

            Assert.AreEqual(expectedMaxProfit, actualMaxProfit);
        }

        [TestMethod]
        public void BestTimeToBye_1_Proft4()
        {
            int[] price = { 3, 2, 6, 5, 0, 3 };
            int expectedProfit = 4;

            assertMaxProfit(price, expectedProfit);
        }

        [TestMethod]
        public void BestTimeToBy_1_ZeroInput()
        {
            int expectedProfit = 0;
            int[] prices = { };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void BestTimeToBy_Profit0()
        {
            int expectedProfit = 0;
            int[] prices = { 2, 1 };

            assertMaxProfit(prices, expectedProfit);
        }
    }
}
