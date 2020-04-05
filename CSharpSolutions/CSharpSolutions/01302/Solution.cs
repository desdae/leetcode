using CSharpSolutions.Common;
using System;

namespace CSharpSolutions._01302
{
    public class Solution
    {

        int maxd;
        int sum;

        public void TravMaxd(TreeNode root, int d)
        {
            if (root == null) return;
            maxd = Math.Max(d, maxd);
            TravMaxd(root.left, d + 1);
            TravMaxd(root.right, d + 1);
        }

        public void TravSum(TreeNode root, int d)
        {
            if (root == null) return;
            if (d == maxd) sum += root.val;
            TravSum(root.left, d + 1);
            TravSum(root.right, d + 1);
        }

        public int DeepestLeavesSum(TreeNode root)
        {
            maxd = 0;
            TravMaxd(root, 1);
            sum = 0;
            TravSum(root, 1);
            return sum;
        }
    }
}
