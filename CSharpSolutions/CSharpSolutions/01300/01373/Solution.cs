using CSharpSolutions.Common;
using System;
using System.Collections.Generic;

namespace CSharpSolutions._01300._01373
{
    public class Solution
    {
        long maxSum = 0;
        bool isBST = false;

        Dictionary<TreeNode, bool> d = new Dictionary<TreeNode, bool>();

        private bool IsBST(TreeNode root, int min, int max)
        {
            if (root == null)
                return true;

            if (root.val < min || root.val > max)
            {
                return false;
            }

            return (IsBST(root.left, min, root.val - 1) && IsBST(root.right, root.val + 1, max));
        }

        private void FlagBST(TreeNode root)
        {
            if (root == null) return;
            d[root] = true;
            FlagBST(root.left);
            FlagBST(root.right);
        }

        private long SumBST(TreeNode root)
        {
            if (root == null)
                return 0;
            var ret = root.val + SumBST(root.left) + SumBST(root.right);
            maxSum = Math.Max(ret, maxSum);
            return ret;
        }

        private void DFS(TreeNode root)
        {
            if (root == null)
                return;
            if (!(d.ContainsKey(root)) && IsBST(root, int.MinValue, int.MaxValue))
            {
                FlagBST(root);
                maxSum = Math.Max(SumBST(root), maxSum);
            }
            DFS(root.left);
            DFS(root.right);
        }
        public int MaxSumBST(TreeNode root)
        {
            maxSum = long.MinValue;
            DFS(root);
            maxSum = Math.Max(maxSum, 0);
            return (int)maxSum;
        }
    }
}
