using System.Collections.Generic;

namespace CSharpSolutions._00771
{
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            var jews = new HashSet<char>();
            int res = 0;
            for (int i = 0; i < J.Length; i++)
                jews.Add(J[i]);
            for (int i = 0; i < S.Length; i++)
                if (jews.Contains(S[i])) res++;
            return res;
        }
    }
}
