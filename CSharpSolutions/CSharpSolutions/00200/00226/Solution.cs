using CSharpSolutions.Common;

namespace CSharpSolutions._00226
{
    public class Solution
    {
        private void DFS(TreeNode root)
        {
            if (root == null) return;
            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;
            DFS(root.left);
            DFS(root.right);
        }
        public TreeNode InvertTree(TreeNode root)
        {
            DFS(root);
            return root;
        }
    }
}
