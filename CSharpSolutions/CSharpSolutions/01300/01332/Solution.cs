using System;
using System.Linq;

namespace CSharpSolutions._01300._01332
{
    public class Solution
    {
        public int RemovePalindromeSub(string s)
        {
            if (s == "") return 0;
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
                if (s[i++] != s[j--]) return 2;
            return 1;
        }

        public class SolutionOneLine
        {
            public int RemovePalindromeSub(string s) => s == "" ? 0 : s.Equals(new String(s.Reverse().ToArray())) ? 1 : 2;
        }
    }
}
