using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class RemoteDuplicate_unittest
    {
        private void AssertRemoveDuplication(int[] data, int[] expectedArray)
        {
            RemoveDuplication r = new RemoveDuplication();
            int actualLength = r.RemoveDuplicate(data);

            int expectedLength = expectedArray.Length;

            Assert.AreEqual(expectedLength, actualLength);

            for (int i = 0; i < actualLength; i++)
            {
                Assert.AreEqual(data[i], expectedArray[i],
                        string.Format("Expected: {0}, Actual: {1}",
                                       GetArrayContent(expectedArray), GetArrayContent(data))
                    );
            }
        }

        private string GetArrayContent(int[] data)
        {
            string result = "[";
            foreach (int item in data)
            {
                result += item.ToString() + ",";
            }

            result = result.Remove(result.Length - 1, 1) + "]";

            return result;
        }


        [TestMethod]
        public void testcase()
        {
            int[] data = { };
            int[] expected = { };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase0()
        {
            int[] data = { 1 };
            int[] expected = { 1 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase1()
        {
            int[] data = { 1, 1 };
            int[] expected = { 1 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase2()
        {
            int[] data = { 1, 2 };
            int[] expected = { 1, 2 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase3()
        {
            int[] data = { 1, 1, 1 };
            int[] expected = { 1 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase4()
        {
            int[] data = { 1, 2, 2 };
            int[] expected = { 1, 2 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase5()
        {
            int[] data = { 1, 1, 2 };
            int[] expected = { 1, 2 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase6()
        {
            int[] data = { 1, 2, 3 };
            int[] expected = { 1, 2, 3 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase7()
        {
            int[] data = { 1, 1, 1, 1 };
            int[] expected = { 1 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase8()
        {
            int[] data = { 1, 1, 2, 2 };
            int[] expected = { 1, 2 };

            AssertRemoveDuplication(data, expected);
        }

        [TestMethod]
        public void testCase9()
        {
            int[] data = { 1, 1, 2, 3 };
            int[] expected = { 1, 2, 3 };

            AssertRemoveDuplication(data, expected);
        }
    }
}
