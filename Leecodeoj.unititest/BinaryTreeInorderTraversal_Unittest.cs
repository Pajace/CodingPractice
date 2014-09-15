using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class BinaryTreeInorderTraversal_Unittest
    {

        private void AssertBTInorder(TreeNode root, List<int> expected)
        {
            BinaryTreeInorderTraversal btInorder = new BinaryTreeInorderTraversal();
            List<int> actual = btInorder.GetInorder(root);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        //  1
        //   \
        //    2
        //   /
        //  3
        [TestMethod]
        public void BinaryTreeTraversal_Inorder_case1()
        {
            TreeNode root = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            root.right = node2;
            node2.left = node3;

            List<int> expected = new List<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(2);

            AssertBTInorder(root, expected);
        }


        //            6
        //           /  \
        //          2    7
        //         / \    \
        //        1   4    9
        //           / \   /
        //          3   5 8
        [TestMethod]
        public void BinaryTreeTraversal_Inorder_case2()
        {
            TreeNode node1 = new TreeNode(1);  
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            TreeNode node7 = new TreeNode(7);
            TreeNode node8 = new TreeNode(8);
            TreeNode node9 = new TreeNode(9);

            node6.left = node2;
            node6.right = node7;
            node2.left = node1;
            node2.right = node4;
            node7.right = node9;
            node4.left = node3;
            node4.right = node5;
            node9.left = node8;

            List<int> expected = new List<int>();
            int[] expectedOrder = { 1, 2,3,4,5,6,7,8,9};
            expected.AddRange(expectedOrder);

            AssertBTInorder(node6, expected);
        }
    }
}
