using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class MaxDepthOfBinaryTree_Unittest
    {
        private void AssertMaxDepth(TreeNode root, int expectedDepth)
        {
            MaxDepthOfBinaryTree maxDepthOfBinaryTree = new MaxDepthOfBinaryTree();
            int actualDepth = maxDepthOfBinaryTree.CalculateMaxDepth(root);

            Assert.AreEqual(expectedDepth, actualDepth);
        }

        [TestMethod]
        public void MaxDepthOfBinaryTree_CalculateMaxDepth_0Depth()
        {
            AssertMaxDepth(null, 0);
        }
    }
}
