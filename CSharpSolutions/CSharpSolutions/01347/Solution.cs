using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01347
{
    public class Solution
    {
        public int MinSteps(string s, string t)
        {
            var ds = new Dictionary<char, int>();
            var dt = new Dictionary<char, int>();
            var ls = new List<char>();
            var lt = new List<char>();
            var ms = new HashSet<char>();
            var mt = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                ls.Add(s[i]);
                lt.Add(t[i]);
                ms.Add(s[i]);
                mt.Add(t[i]);
                if (!ds.ContainsKey(s[i]))
                    ds[s[i]] = 0;
                ds[s[i]]++;
                if (!dt.ContainsKey(t[i]))
                    dt[t[i]] = 0;
                dt[t[i]]++;
            }
            ls.Sort();
            lt.Sort();

            int res = 0;
            foreach (var c in ls)
            {
                if (dt.ContainsKey(c) && dt[c] > 0)
                {
                    dt[c]--;
                }
                else
                {
                    res++;
                }
            }

            return res;
        }
    }
}
