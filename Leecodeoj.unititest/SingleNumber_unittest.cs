using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class SingleNumber_unittest
    {
        private int[] data = new int[60001];

        [TestInitialize]
        public void setup()
        {
            for (int i = 0; i < 60000; i += 2)
            {                
                data[i] = i;
                data[i + 1] = i;
            }
            data[60000] = -99;
        }

        [TestMethod]
        public void SingleNumber_TestCase_XOR()
        {
            int actual = SingleNumber.SolutionXOR(data);
            int expected = -99;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleNumber_TestCase_SortFirst()
        {
            int actual = SingleNumber.SolutionSortFirst(data);
            int expected = -99;

            Assert.AreEqual(expected, actual);
        }
    }
}
