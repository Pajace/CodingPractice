using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class PeopleQueue_Unittest
    {
        private void compareTwoArray(int[] expecteds, int[] actuals)
        {
            Assert.AreEqual(expecteds.Length, actuals.Length, "The array length is not equal.");

            for (int i = 0; i < expecteds.Length; i++)
            {
                Assert.AreEqual(expecteds[i], actuals[i], "The element at index {0} is different.", i);
            }
        }

        [TestMethod]
        public void test1()
        {
            int[] expecteds = { 3, 6, 9, 2, 7, 1, 8 };
            int[] actuals = PeopleQueue.Select(10, 3, 3, 7);

            compareTwoArray(expecteds, actuals);
        }

        [TestMethod]
        public void test2()
        {
            int[] expecteds = { 6, 11, 4, 10, 5, 1, 9 };
            int[] actuals = PeopleQueue.Select(12, 6, 5, 7);

            compareTwoArray(expecteds, actuals);
        }

        [TestMethod]
        public void test3()
        {
            int[] expecteds = { 4, 8, 2, 7, 3, 10 };
            int[] actuals = PeopleQueue.Select(10, 4, 4, 6);

            compareTwoArray(expecteds, actuals);
        }

        [TestMethod]
        public void test4()
        {
            int[] expecteds = { 8, 3, 14, 11, 9, 7, 10, 13, 2, 12 };
            int[] actuals = PeopleQueue.Select(15, 8, 10, 10);

            compareTwoArray(expecteds, actuals);
        }

        [TestMethod]
        public void test5()
        {
            int[] expecteds = { 2, 6, 10, 5, 1 };
            int[] actuals = PeopleQueue.Select(10, 2, 4, 5);

            compareTwoArray(expecteds, actuals);
        }
    }
}
