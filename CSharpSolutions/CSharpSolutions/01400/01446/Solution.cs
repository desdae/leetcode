using System;

namespace CSharpSolutions._01400._01446
{
    public class Solution
    {
        public int MaxPower(string s)
        {
            char c = s[0];
            int l = 0;
            int m = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != c)
                {
                    m = Math.Max(m, l);
                    l = 1;
                    c = s[i];
                }
                else
                {
                    l++;
                }
            }
            return Math.Max(m, l);
        }
    }
}
