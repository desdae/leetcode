using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CSharpSolutions._01300._01366
{
    public class Solution
    {
        public string RankTeams(string[] votes)
        {
            BigInteger[] w = new BigInteger[26];
            BigInteger m = 1;
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = m;
                m = m * 100;
            }
            var v = new Dictionary<char, BigInteger>();
            for (int i = 0; i < votes.Length; i++)
            {
                var s = votes[i];
                for (int j = 0; j < s.Length; j++)
                {
                    if (!v.ContainsKey(s[j]))
                        v[s[j]] = 0;
                    v[s[j]] += w[s.Length - j - 1];
                }
            }

            var res = "";
            foreach (var x in v.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                res += x.Key;
            }

            return res;
        }
    }
}
