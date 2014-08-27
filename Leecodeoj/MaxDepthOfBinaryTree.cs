//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/maximum-depth-of-binary-tree/</reference>
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (root == null)
                return 0;
            return -1; // Not Implement
        }
    }
}
