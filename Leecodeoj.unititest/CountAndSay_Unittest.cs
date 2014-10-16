using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class CountAndSay_Unittest
    {
        private void AssertCountAndSay(int inputNumber, String expectedSay)
        {
            CountAndSay c = new CountAndSay();
            string actual = c.SayIt(inputNumber);

            Assert.AreEqual(expectedSay, actual);
        }

        [TestMethod]
        public void CountAndSay_Input1()
        {
            int inputNumber = 1;
            string expectd = "1";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input2()
        {
            int inputNumber = 2;
            string expectd = "11";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input3()
        {
            int inputNumber = 3;
            string expectd = "21";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input4()
        {
            int inputNumber = 4;
            string expectd = "1211";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input5()
        {
            int inputNumber = 5;
            string expectd = "111221";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input6()
        {
            int inputNumber = 6;
            string expectd = "312211";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input7()
        {
            int inputNumber = 7;
            string expectd = "13112221";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input8()
        {
            int inputNumber = 8;
            string expectd = "1113213211";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input9()
        {
            int inputNumber = 9;
            string expectd = "31131211131221";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input10()
        {
            int inputNumber = 10;
            string expectd = "13211311123113112211";

            AssertCountAndSay(inputNumber, expectd);
        }

        [TestMethod]
        public void CountAndSay_Input11()
        {
            int inputNumber = 11;
            string expectd = "11131221133112132113212221";

            AssertCountAndSay(inputNumber, expectd);
        }
    }
}
