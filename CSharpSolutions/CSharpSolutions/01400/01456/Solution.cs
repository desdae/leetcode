using System;

namespace CSharpSolutions._01400._01456
{
    public class Solution
    {
        private bool IsWovel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
        public int MaxVowels(string s, int k)
        {
            int c = 0;
            int m = 0;
            for (int i = 0; i < k; i++)
                if (IsWovel(s[i]))
                    c++;
            m = Math.Max(m, c);

            for (int i = 1; i < s.Length - k + 1; i++)
            {
                if (IsWovel(s[i - 1]))
                    c--;
                if (IsWovel(s[i + k - 1]))
                    c++;
                m = Math.Max(m, c);
            }

            return m;
        }
    }
}
