using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day09
{
    public class Solution
    {
        private string Process(string s)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#' && sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    if (s[i] != '#')
                        sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
        public bool BackspaceCompare(string S, string T)
        {
            return (Process(S) == Process(T));
        }
    }
}
