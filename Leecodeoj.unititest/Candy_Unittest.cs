using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class Candy_Unittest
    {

        private void AssertMinimunCandiesYouMustGive(int expected, int[] ratings)
        {
            Candy candy = new Candy();

            int actual = candy.calculateMinimunCandies(ratings);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testIncrease()
        {
            int[] ratings = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 55;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void test()
        {
            int[] ratings = { 3, 2, 1, 4, 3 };
            int expected = 9;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void test1()
        {
            int[] ratings = { 3, 2, 1, 1, 4, 3, 3 };
            int expected = 11;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }


        [TestMethod]
        public void noElement()
        {
            int[] ratings = { };
            int expected = 0;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void noElement2()
        {
            int[] ratings = null;
            int expected = 0;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void oneElement()
        {
            int[] ratings = { 100 };
            int expected = 1;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void twoElementDecrease()
        {
            int[] ratings = { 4, 3 };
            int expected = 3;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void twoElementIncrease()
        {
            int[] ratings = { 1, 5 };
            int expected = 3;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void threeElementIncrease()
        {
            int[] ratings = { 1, 2, 3 };
            int expected = 6;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void threeElementDecrease()
        {
            int[] ratings = { 30, 25, 13 };
            int expected = 6;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void comprehensiveTest1()
        {
            int[] ratings = { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 7, 8, 8, 5, 3, 1, 9 };
            int expected = 54;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void comprehensiveTest2()
        {
            int[] ratings = { 1, 2, 2 };
            int expected = 4;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }

        [TestMethod]
        public void comprehensiveTest3()
        {
            int[] ratings = { 1, 2, 3, 4, 5, 5, 5, 4, 4, 3, 3, 3, 2, 2, 1 };
            int expected = 29;

            AssertMinimunCandiesYouMustGive(expected, ratings);
        }
    }
}
