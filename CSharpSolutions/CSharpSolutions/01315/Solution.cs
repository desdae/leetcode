using CSharpSolutions.Common;

namespace CSharpSolutions._01315
{
    public class Solution
    {
        int sum;
        public void Traverse(TreeNode root, TreeNode parent, TreeNode grandParent)
        {
            if (root == null) return;

            Traverse(root.left, root, parent);
            Traverse(root.right, root, parent);

            if (grandParent != null && grandParent.val % 2 == 0)
                sum += root.val;
        }
        public int SumEvenGrandparent(TreeNode root)
        {
            sum = 0;
            Traverse(root, null, null);
            return sum;
        }
    }
}
