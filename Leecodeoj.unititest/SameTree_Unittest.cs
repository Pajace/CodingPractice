using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leecodeoj;

namespace Leecodeoj.unititest
{
    [TestClass]
    public class SameTree_Unittest
    {
        private void assertIsTheSameTree(TreeNode root1, TreeNode root2,
                    bool expected)
        {
            SameTree st = new SameTree();
            bool actual = st.isSameTree(root1, root2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SameTree_isSameTree_SameTree()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            bool expected = true;
            assertIsTheSameTree(root1, root2, expected);
        }

        [TestMethod]
        public void SameTree_isSameTree_SameStructureWithDifferentValue()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value2();

            bool expected = false;
            assertIsTheSameTree(root1, root2, expected);
        }

        [TestMethod]
        public void SameTree_isSameTree_NodeWithNull()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();

            bool expected = false;
            assertIsTheSameTree(root1, null, expected);
        }

        [TestMethod]
        public void SameTree_isSameTree_NullWithNode()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();

            bool expected = false;
            assertIsTheSameTree(null, root1, expected);
        }

        [TestMethod]
        public void SameTree_isSameTree_BothNull()
        {
            assertIsTheSameTree(null, null, true);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest1()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();
            
            TreeNode node10 = new TreeNode(10);
            root2.left.right.left = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest2()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.left.right.right = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest3()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.right.left.left = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest4()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.right.left.right = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest5()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.right.right.right = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest6()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.right.right.left = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest7()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.left.left.left.left = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest8()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.left.left.left.right = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest9()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.left.left.right.right = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        [TestMethod]
        public void SameTree_isSameTree_OneMoreNodeTest10()
        {
            TreeNode root1 = createTreeNode9NodeType1_value1();
            TreeNode root2 = createTreeNode9NodeType1_value1();

            TreeNode node10 = new TreeNode(10);
            root2.left.left.right.left = node10;

            assertIsTheSameTree(root1, root2, false);
        }

        //       1
        //      / \
        //     2    3
        //    / \   /\
        //   4   5 6  7
        //  / \
        // 8   9
        private TreeNode createTreeNode9NodeType1_value1()
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

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            node4.left = node8;
            node4.right = node9;
            node7.right = node9;

            return node1;
        }

        //       1
        //      / \
        //     2   5
        //    / \  /\
        //   3  4 6  7
        //  / \
        // 8   9
        private TreeNode createTreeNode9NodeType1_value2()
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

            node1.left = node2;
            node1.right = node5;
            node2.left = node3;
            node2.right = node4;
            node3.left = node8;
            node5.left = node6;
            node5.right = node7;
            node7.right = node9;

            return node1;
        }
    }
}
