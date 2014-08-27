//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/same-tree/</reference>
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    /// <summary>
    /// Given two binary trees, write a function to check if they are equal or not.
    /// Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
    /// </summary>
    public class SameTree
    {
        public bool isSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null ^ root2 == null) return false;

            Stack<TreeNode> stack1 = new Stack<TreeNode>();
            Stack<TreeNode> stack2 = new Stack<TreeNode>();

            stack1.Push(root1);
            stack2.Push(root2);

            while (stack1.Count > 0)
            {
                var node1 = stack1.Pop();
                var node2 = stack2.Pop();

                if (node1.val != node2.val)
                    return false;

                bool isOnlyOneNodeHasLeftChild = node1.left == null ^ node2.left == null;
                bool isOnlyOneNodeHasRightChild = node1.right == null ^ node2.right == null;
                bool isBothNodeHasLeftChild = node1.left != null && node2.left != null;
                bool isBothNodeHasRightChild = node1.right != null && node2.right != null;

                if (isOnlyOneNodeHasLeftChild || isOnlyOneNodeHasRightChild)
                    return false;

                
                if (isBothNodeHasLeftChild)
                {
                    stack1.Push(node1.left);
                    stack2.Push(node2.left);
                }

                if (isBothNodeHasRightChild)
                {
                    stack1.Push(node1.right);
                    stack2.Push(node2.right);
                }
            }

            return true;
        }
    }
}
