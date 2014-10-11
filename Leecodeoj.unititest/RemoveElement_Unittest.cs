using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class RemoveElement_Unittest
    {
        private void AssertRemoveElement(int[] inputData, int element, int[] expectedData)
        {
            RemoveElementUtil inputElement = new RemoveElementUtil();
            int actualLength = inputElement.removeElement(inputData, element);

            Assert.AreEqual(expectedData.Length, actualLength);
            for (int i = 0; i < expectedData.Length; i++)
            {
                Assert.AreEqual(expectedData[i], inputData[i]);
            }
        }

        [TestMethod]
        public void TestMethod0()
        {
            int[] inputData = {  };
            int[] expectedData = {  };
            int inputElement = 0;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] inputData = { 2 };
            int[] expectedData = { 2 };
            int inputElement = 3;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] inputData = { 1 };
            int[] expectedData = { };
            int inputElement = 1;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] inputData = { 3, 3 };
            int[] expectedData = {3, 3 };
            int inputElement = 5;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] inputData = { 4, 5 };
            int[] expectedData = { 5 };
            int inputElement = 4;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] inputData = { 3, 3 };
            int[] expectedData = { };
            int inputElement = 3;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] inputData = { 2, 3, 3 };
            int[] expectedData = { 3, 3 };
            int inputElement = 2;

            AssertRemoveElement(inputData, inputElement, expectedData);
        }

    }
}
