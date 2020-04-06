using System;
using System.Collections.Generic;
using static CSharpSolutions._01300._01361.Solution;

namespace CSharpSolutions._01300._01372
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution
    {
        private int max;
        Dictionary<TreeNode, bool> visr = new Dictionary<TreeNode, bool>();
        Dictionary<TreeNode, bool> visl = new Dictionary<TreeNode, bool>();

        private void ZZ1(TreeNode root, int d, int prev)
        {
            if (root == null)
                return;
            max = Math.Max(d, max);
            if (prev == 0)
            {
                if (root.right != null)
                {
                    if (visr.ContainsKey(root.right))
                        return;
                    visr[root.right] = true;
                }
                ZZ1(root.right, d + 1, 1);
            }
            if (prev == 1)
            {
                if (root.left != null)
                {
                    if (visl.ContainsKey(root.left))
                        return;
                    visr[root.left] = true;
                }

                ZZ1(root.left, d + 1, 0);
            }
        }
        private void DFS(TreeNode root)
        {
            ZZ1(root, 0, 0);
            ZZ1(root, 0, 1);
        }

        private void DFS2(TreeNode root)
        {
            if (root == null)
                return;
            DFS(root);
            DFS2(root.left);
            DFS2(root.right);
        }
        public int LongestZigZag(TreeNode root)
        {
            max = 0;
            DFS2(root);
            return max;
        }
    }
}
