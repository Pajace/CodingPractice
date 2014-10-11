//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/maximum-depth-of-binary-tree/</reference>
//----------------------------------------------------------------------

using System.Collections.Generic;
namespace Leecodeoj
{

    /// <summary>
    /// Definition for binary tree
    /// public class TreeNode {
    ///     int val;
    ///     TreeNode left;
    ///     TreeNode right;
    ///     TreeNode(int x) { val = x; }
    /// }
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { this.val = x; }
    }

    /// <summary>
    /// Given a binary tree, find its maximum depth.    
    /// </summary>
    public class MaxDepthOfBinaryTree
    {
        public int CalculateMaxDepth(TreeNode root)
        {
            int maxDepth = 0;

            if (root == null)
                return maxDepth;

            Stack<TreeNode> remainPathStack = new Stack<TreeNode>();
            Stack<TreeNode> currentPathStack = new Stack<TreeNode>();

            remainPathStack.Push(root);

            TreeNode node;
            while (IsNotEmpty(remainPathStack))
            {
                node = remainPathStack.Peek();

                if (IsCurrentPathDownToLeafOrOnBackWay(currentPathStack, node))
                {
                    if (currentPathStack.Count > maxDepth)
                        maxDepth = currentPathStack.Count;
                    remainPathStack.Pop();
                    currentPathStack.Pop();
                }
                else
                {
                    currentPathStack.Push(node);
                    if (node.left != null)
                        remainPathStack.Push(node.left);
                    if (node.right != null)
                        remainPathStack.Push(node.right);
                }
            }

            return maxDepth;
        }

        private static bool IsNotEmpty(Stack<TreeNode> currentPathStack)
        {
            return currentPathStack.Count != 0;
        }

        private static bool IsCurrentPathDownToLeafOrOnBackWay(Stack<TreeNode> currentPathStack, TreeNode node)
        {
            // 因為當目前的節點沒有任何子節點時， remainPathStack 就不會 push 節點進去
            // 此時，remainPathStack 的 peek 會和 currentPathStack 的 peek 相同
            if (currentPathStack.Count == 0)
                return false;
            return node == currentPathStack.Peek();
        }
    }
}
