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

            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<TreeNode> path = new Stack<TreeNode>();

            stack.Push(root);

            while (stack.Count != 0)
            {
                root = stack.Peek();

                if (path.Count!=0 && root == path.Peek()) // 到最末端節點
                {
                    if (path.Count > maxDepth)
                        maxDepth = path.Count;
                    stack.Pop();
                    path.Pop();
                }
                else
                {
                    path.Push(root);
                    if (root.left != null)
                        stack.Push(root.left);
                    if (root.right != null)
                        stack.Push(root.right);
                }
            }

            return maxDepth;
        }
    }
}
