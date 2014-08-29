
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class BestTimeToBuy_II_Unittest
    {
        private void assertMaxProfit(int[] prices, int expectedMaxProfit)
        {
            BestTimeToBy_II b = new BestTimeToBy_II();

            int actualMaxProfit = b.maxProfit(prices);

            Assert.AreEqual(expectedMaxProfit, actualMaxProfit);
        }



        [TestMethod]
        public void maxProfit_zeroProfit_input1()
        {
            int expectedProfit = 0;
            int[] prices = { 2, 1 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_zeroProfit_input2()
        {
            int expectedProfit = 0;
            int[] prices = { 8, 7, 6, 5, 4, 3, 2, 1 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_zeroProfit_input3()
        {
            int expectedProfit = 0;
            int[] prices = { };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_IncreaseStock()
        {
            int expectedProfit = 8;
            int[] prices = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_OnePeekStock()
        {
            int expectedProfit = 8;
            int[] prices = { 1, 3, 6, 8, 9, 6, 4, 2, 1 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_TwoPeekStock()
        {
            int expectedProfit = 19;
            int[] prices = { 1, 3, 5, 8, 11, 6, 3, 2, 1, 1, 1, 1, 1, 4, 8, 10, 5, 2, 1, 0 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_OneFlatPeek()
        {
            int expectedProfit = 1;
            int[] prices = { 1, 1, 2, 2, 1, 1 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_TwoFlatPeek()
        {
            int expectedProfit = 6;
            int[] prices = { 1, 1, 2, 2, 1, 1, 0, 0, 5, 5, 0, 0 };

            assertMaxProfit(prices, expectedProfit);
        }

        [TestMethod]
        public void maxProfit_OneByOneBuySell()
        {
            int expectedProfit = 4;
            int[] prices = { 5, 6, 5, 6, 5, 6, 5, 6 };

            assertMaxProfit(prices, expectedProfit);
        }
    }
}
