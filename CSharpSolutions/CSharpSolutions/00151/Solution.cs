using System;

namespace CSharpSolutions._00151
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            string[] x = s.Trim().Split(' ');
            string res = string.Empty;
            int i = x.Length;
            while (i-- > 0)
                if (x[i] != String.Empty)
                    res += x[i].Trim() + " ";
            return res.Trim();
        }
    }
}
