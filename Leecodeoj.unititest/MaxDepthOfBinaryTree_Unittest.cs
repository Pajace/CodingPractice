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

        [TestMethod]
        public void MaxDepthOfBinaryTree_CalculateMaxDepth_6Depth()
        {
            const int numberOfNodes = 12;
            TreeNode[] nodes = new TreeNode[numberOfNodes];
            for (int i = 0; i < numberOfNodes; i++)
                nodes[i] = new TreeNode(i);

            nodes[0].left = nodes[1];
            nodes[0].right = nodes[2];
            nodes[1].left = nodes[3];
            nodes[1].right = nodes[4];
            nodes[2].right = nodes[8];
            nodes[3].left = nodes[5];
            nodes[3].right = nodes[6];
            nodes[5].left = nodes[7];
            nodes[8].right = nodes[9];
            nodes[9].right = nodes[10];
            nodes[10].right = nodes[11];

            AssertMaxDepth(nodes[0], 6);
        }
    }
}
