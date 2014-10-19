using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class PalindromeNumber_Unittest
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetInputNumberFromMethodName()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);
            var methodName = sf.GetMethod().Name;
            return methodName.Replace("PalindromNumber_TestCase_Input_", "").Replace("_", "-");
        }


        private void AssertPalindromeNumber(int inputNumber, bool expected)
        {
            PalindromeNumber palindrome = new PalindromeNumber();
            bool actual = palindrome.IsPalindrome(inputNumber);

            Assert.AreEqual(expected, actual, "InputNumber is " + inputNumber.ToString());
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_0()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_1()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_3()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_5()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_7()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_9()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input__1()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = false;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_10()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = false;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_313()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_1001()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = true;
            AssertPalindromeNumber(inputNumber, expected);
        }

        [TestMethod]
        public void PalindromNumber_TestCase_Input_1000021()
        {
            int inputNumber = int.Parse(GetInputNumberFromMethodName());
            bool expected = false;
            AssertPalindromeNumber(inputNumber, expected);
        }
    }
}
