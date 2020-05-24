using CSharpSolutions.Common;
using System.Collections.Generic;

namespace CSharpSolutions._01400._01457
{
    public class Solution
    {
        private int paths;

        private void DFS(TreeNode root, Dictionary<int, int> pals, int odd)
        {
            if (root == null)
                return;
            if (!pals.ContainsKey(root.val))
                pals[root.val] = 0;

            pals[root.val]++;
            if (pals[root.val] % 2 == 1)
                odd++;
            else
                odd--;

            if (root.left == null && root.right == null && odd <= 1)
                paths++;

            DFS(root.left, pals, odd);
            DFS(root.right, pals, odd);

            pals[root.val]--;
            if (pals[root.val] == 0)
                pals.Remove(root.val);
        }
        public int PseudoPalindromicPaths(TreeNode root)
        {
            paths = 0;
            DFS(root, new Dictionary<int, int>(), 0);
            return paths;
        }
    }
}
