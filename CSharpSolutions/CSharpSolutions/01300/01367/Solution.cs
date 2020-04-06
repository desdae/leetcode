using CSharpSolutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01300._01367
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
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
        bool flag = false;
        private void DFS(ListNode n, TreeNode root)
        {
            if (root == null || n == null)
                return;
            if (n.val != root.val)
                return;
            if (n.next == null)
            {
                flag = true;
                return;
            }
            DFS(n.next, root.left);
            DFS(n.next, root.right);
        }

        private void DFS2(ListNode n, TreeNode root)
        {
            if (root == null) return;
            if (flag) return;
            flag = false;
            DFS(n, root);
            if (flag)
                return;
            DFS2(n, root.left);
            DFS2(n, root.right);
        }
        public bool IsSubPath(ListNode head, TreeNode root)
        {
            DFS2(head, root);
            return flag;
        }
    }
}
