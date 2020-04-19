using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSolutions._01400._01417
{
    public class Solution
    {
        public string Reformat(string s)
        {
            List<char> c = new List<char>();
            List<char> d = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                    d.Add(s[i]);
                else
                    c.Add(s[i]);
            }

            if (Math.Abs(c.Count - d.Count) > 1)
                return "";

            StringBuilder res = new StringBuilder();
            if (c.Count - d.Count == 1)
            {
                for (int i = 0; i < d.Count; i++)
                {
                    res.Append(c[i]);
                    res.Append(d[i]);
                }
                res.Append(c.Last());
            }
            else
            {
                for (int i = 0; i < c.Count; i++)
                {
                    res.Append(d[i]);
                    res.Append(c[i]);
                }
                if (d.Count - c.Count == 1)
                    res.Append(d.Last());
            }
            return res.ToString();
        }
    }
}
