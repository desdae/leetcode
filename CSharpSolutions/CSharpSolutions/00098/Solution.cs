using CSharpSolutions.Common;
using System;
using System.Collections.Generic;

namespace CSharpSolutions._00098
{
    public class Solution
    {
        private bool valid;

        private long MaxValue(TreeNode root, long currMax)
        {
            if (root == null) return currMax;
            long newMax = Math.Max(currMax, root.val);
            long res = Math.Max(Math.Max(root.val, MaxValue(root.left, newMax)), Math.Max(root.val, MaxValue(root.right, newMax)));
            return res;
        }

        private long MinValue(TreeNode root, long currMin)
        {
            if (root == null) return currMin;
            long newMin = Math.Min(currMin, root.val);
            long res = Math.Min(Math.Min(root.val, MinValue(root.left, newMin)), Math.Min(root.val, MinValue(root.right, newMin)));
            return res;
        }

        private void CheckBST(TreeNode root)
        {
            if (root == null) return;
            if (root.left == null && root.right == null) return;
            var maxv = MaxValue(root.left, long.MinValue);
            if (root.val <= maxv)
            {
                valid = false;
                return;
            }
            var minv = MinValue(root.right, long.MaxValue);
            if (root.val >= minv)
            {
                valid = false;
                return;
            }
            CheckBST(root.left);
            CheckBST(root.right);
        }
        public bool IsValidBST(TreeNode root)
        {
            valid = true;
            CheckBST(root);
            return valid;
        }
    }
}
