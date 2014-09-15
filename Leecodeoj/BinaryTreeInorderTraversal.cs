using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    public class BinaryTreeInorderTraversal
    {
        public List<int> GetInorder(TreeNode root)
        {
            List<int> result = new List<int>();

            Stack<TreeNode> bufferStack = new Stack<TreeNode>();
            while (bufferStack.Count != 0 || root != null)
            {
                if (root != null)
                {
                    bufferStack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = bufferStack.Pop();
                    result.Add(root.val);
                    root = root.right;
                }
            }

            return result;
        }
    }
}
