using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class MaxProductSubarray_unittest
    {
        private void assertMaxProduct(int[] inputArray, int expectedMaxProduct)
        {
            MaxProductSubarray maxProductSubArray = new MaxProductSubarray();
            int actualMaxProduct = maxProductSubArray.FindMaxProduct(inputArray);

            Assert.AreEqual(expectedMaxProduct, actualMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubarray_2element_product6()
        {
            int[] inputArray = { 2, 3, -4, 4 };
            int expectedMaxProduct = 6;

            assertMaxProduct(inputArray, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubarray_2element_with_leader_0()
        {
            int[] inputArary = { 0, 2 };
            int expectedMaxProduct = 2;

            assertMaxProduct(inputArary, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubarray_4element_with_2NegativeNumber()
        {
            int[] inputArray = { -2, 3, -4 };
            int expectedMaxProduct = 24;

            assertMaxProduct(inputArray, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubArray_2Element_with_2NegativeNumber()
        {
            int[] inputArray = { -4, -3 };
            int expectedMaxProduct = 12;

            assertMaxProduct(inputArray, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubArray_3Element_with_2NegativeNumber_and_1_zero()
        {
            int[] inputArray = { -2, 0, -1 };
            int expectedMaxProduct = 0;

            assertMaxProduct(inputArray, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubArray_separator_by_0_with_negative_number()
        {
            int[] inputarray = { -1, -2, -3, 0 , -3, -4, -1};
            int expectedMaxProduct = 12;

            assertMaxProduct(inputarray, expectedMaxProduct);
        }

        [TestMethod]
        public void MaxProductSubArray_SingleNegativeNumber()
        {
            int[] inputArray = { -2 };
            int expectedMaxProduct = -2;

            assertMaxProduct(inputArray, expectedMaxProduct);
        }
    }
}
