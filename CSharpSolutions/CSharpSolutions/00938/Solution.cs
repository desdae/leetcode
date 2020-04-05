using CSharpSolutions.Common;

namespace CSharpSolutions._00938
{
    public class Solution
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null) return 0;
            return RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R) + ((root.val >= L && root.val <= R) ? root.val : 0);
        }
    }
}
