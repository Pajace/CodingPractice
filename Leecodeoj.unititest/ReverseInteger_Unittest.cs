using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class ReverseInteger_Unittest
    {
        private void AssertReverseInteger(int inputNumber, int expected)
        {
            ReverseInteger r = new ReverseInteger();
            int actual = r.reverse_solution2(inputNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case1()
        {
            int expected = 321;
            int inputNumber = 123;

            AssertReverseInteger(inputNumber, expected);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case2()
        {
            int expected = -321;
            int inputNumber = -123;

            AssertReverseInteger(inputNumber, expected);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case3()
        {
            int expected = -789456123;
            int inputNumber = -321654987;

            AssertReverseInteger(inputNumber, expected);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case4()
        {
            int expected = 987654321;
            int inputNumber = 1234567890;

            AssertReverseInteger(inputNumber, expected);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case5()
        {
            int expected = 6540321;
            int inputNumber = 1230456;

            AssertReverseInteger(inputNumber, expected);
        }

        [TestMethod]
        public void ReverseInteger_reverse_case6()
        {
            int expected = 1;
            int inputNumber = 1000000000;

            AssertReverseInteger(inputNumber, expected);
        }
    }
}
