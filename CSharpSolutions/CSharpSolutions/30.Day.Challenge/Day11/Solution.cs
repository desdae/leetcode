using CSharpSolutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day11
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

        private int max = 0;
        private int Depth(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(Depth(root.left), Depth(root.right));
        }

        private void MaxDia(TreeNode root)
        {
            if (root == null) return;
            max = Math.Max(max, Depth(root.right) + Depth(root.left));
            MaxDia(root.left);
            MaxDia(root.right);
        }
        public int DiameterOfBinaryTree(TreeNode root)
        {
            MaxDia(root);
            return max;
        }
    }
}
