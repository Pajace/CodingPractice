using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj.Common;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class UnitTest1
    {
        private void AssertDuplicateSortedList(ListNode node, ListNode expected)
        {
            DuplicateSortedList duplicateSortedList = new DuplicateSortedList();
            ListNode actual = duplicateSortedList.removeDuplicates(node);

            while (expected != null)
            {
                Assert.Equals(expected.val, actual.val);

                actual = actual.next;
                expected = expected.next;
            }

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Duplicate_ThreeNode_OneDuplicate()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(1);
            node.next.next = new ListNode(2);

            ListNode expected = new ListNode(1);
            expected.next = new ListNode(2);

            AssertDuplicateSortedList(node, expected);
        }

        [TestMethod]
        public void Duplicate_EmptyTree_NoDuplicate()
        {
            AssertDuplicateSortedList(null, null);
        }

        [TestMethod]
        public void Duplicate_ThreeNode_TwoDuplicate()
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(1);
            node.next.next = new ListNode(1);

            ListNode expected = new ListNode(1);

            AssertDuplicateSortedList(node, expected);
        }
    }
}
