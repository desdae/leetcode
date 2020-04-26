using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01422
{
    public class Solution
    {
        public int MaxScore(string s)
        {
            int max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                var s1 = s.Substring(0, i);
                var s2 = s.Substring(i, s.Length - i);
                var sc = s1.ToArray().Count(c => c == '0') + s2.ToArray().Count(c => c == '1');
                max = Math.Max(max, sc);
            }
            return max;
        }
    }
}
