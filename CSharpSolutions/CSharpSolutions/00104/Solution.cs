using CSharpSolutions.Common;

namespace CSharpSolutions._00104
{
    public class Solution
    {
        private int maxd;
        private void Traverser(TreeNode root, int currD)
        {
            if (root == null) return;
            currD++;
            if (currD > maxd)
            {
                maxd = currD;
            }
            Traverser(root.left, currD);
            Traverser(root.right, currD);
        }

        public int MaxDepth(TreeNode root)
        {
            maxd = 0;
            Traverser(root, 0);
            return maxd;
        }
    }
}
