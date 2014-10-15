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
            int[] inputArray = { 2, 3, -4, 4};
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
    }
}
