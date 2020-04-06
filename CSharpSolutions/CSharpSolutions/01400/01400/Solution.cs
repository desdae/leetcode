using System.Collections.Generic;
using System.Linq;

namespace CSharpSolutions._01400._01400
{
    public class Solution
    {
        public bool CanConstruct(string s, int k)
        {
            if (s.Length < k)
                return false;
            var d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!d.ContainsKey(s[i]))
                    d[s[i]] = 0;
                d[s[i]]++;
            }
            int uneven = d.Values.Count(v => v % 2 == 1);
            if (uneven > k)
                return false;
            return true;
        }
    }
}
