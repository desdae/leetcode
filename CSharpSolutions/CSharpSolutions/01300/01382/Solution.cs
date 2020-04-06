using CSharpSolutions.Common;
using System.Collections.Generic;

namespace CSharpSolutions._01300._01382
{
    public class Solution
    {
        public void ToList(TreeNode root, List<TreeNode> d)
        {
            if (root == null)
                return;

            ToList(root.left, d);
            d.Add(root);
            ToList(root.right, d);
        }

        public virtual TreeNode Build(List<TreeNode> d, int s, int e)
        {
            if (s > e)
                return null;

            int mid = (s + e) / 2;
            TreeNode n = d[mid];

            n.left = Build(d, s, mid - 1);
            n.right = Build(d, mid + 1, e);

            return n;
        }
        public TreeNode BalanceBST(TreeNode root)
        {
            var d = new List<TreeNode>();
            ToList(root, d);

            return Build(d, 0, d.Count - 1);
        }
    }
}
