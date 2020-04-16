using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day16
{
    public class Solution
    {
        private bool flag;
        private void DFS(int x, int o, int c, StringBuilder sb)
        {
            if (c > o)
                return; 
            if (flag)
                return;
            if (x == sb.Length)
            {
                if (c == o)
                    flag = true;
                return;
            }
            if (sb[x] == '*')
            {
                DFS(x + 1, o, c, sb);
                DFS(x + 1, o + 1, c, sb);
                DFS(x + 1, o, c + 1, sb);
            } 
            else if (sb[x] == '(')
            {
                DFS(x + 1, o + 1, c, sb);
            }
            else
            {
                DFS(x + 1, o, c + 1, sb);
            }
        }
        public bool CheckValidString(string s)
        {
            DFS(0, 0, 0, new StringBuilder(s));
            return flag;
        }
    }
}
