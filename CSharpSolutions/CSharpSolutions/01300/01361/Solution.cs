using System.Collections.Generic;

namespace CSharpSolutions._01300._01361
{
    public class Solution
    {
        private int c = 0;
        private bool f = true;

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public void DFS(TreeNode t)
        {
            if (t == null) return;
            if (!f) return;
            if (t.val == 1)
            {
                f = false;
                return;
            }
            t.val++;
            c++;
            DFS(t.left);
            DFS(t.right);
        }
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            Dictionary<int, TreeNode> d = new Dictionary<int, TreeNode>();
            for (int i = 0; i < n; i++)
            {
                if (!d.ContainsKey(i))
                    d[i] = new TreeNode(0);
                if (!d.ContainsKey(leftChild[i]) && leftChild[i] != -1)
                    d[leftChild[i]] = new TreeNode(0);
                if (!d.ContainsKey(rightChild[i]) && rightChild[i] != -1)
                    d[rightChild[i]] = new TreeNode(0);
                if (leftChild[i] != -1)
                    d[i].left = d[leftChild[i]];
                if (rightChild[i] != -1)
                    d[i].right = d[rightChild[i]];
            }
            DFS(d[0]);
            return (c == n && f);
        }
    }
}
