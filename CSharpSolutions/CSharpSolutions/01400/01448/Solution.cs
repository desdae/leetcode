using CSharpSolutions.Common;
using System;

namespace CSharpSolutions._01400._01448
{
    public class Solution
    {
        int good;
        private void DFS(int max, TreeNode root)
        {
            if (root == null)
                return;
            if (root.val >= max)
                good++;
            max = Math.Max(root.val, max);
            DFS(max, root.left);
            DFS(max, root.right);
        }
        public int GoodNodes(TreeNode root)
        {
            good = 0;
            DFS(int.MinValue, root);
            return good;
        }
    }
}
