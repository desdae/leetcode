using CSharpSolutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00600._00617
{
    public class Solution
    {
        private void DFS(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return;
            if (t2 == null)
                return;
            t1.val += t2.val;
            bool goLeft = true;
            bool goRight = true;
            if (t1.left == null && t2.left != null)
            {
                t1.left = t2.left;
                goLeft = false;
            }
            if (t1.right == null && t2.right != null)
            {
                t1.right = t2.right;
                goRight = false;
            }
            if (goLeft)
                DFS(t1.left, t2.left);
            if (goRight)
                DFS(t1.right, t2.right);
        }
        
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            DFS(t1, t2);
            return t1;
        }
    }
}
