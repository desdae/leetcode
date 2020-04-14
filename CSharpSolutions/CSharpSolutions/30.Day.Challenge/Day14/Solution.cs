using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._30.Day.Challenge.Day14
{
    public class Solution
    {
        public string StringShift(string s, int[][] shift)
        {
            int offset = 0;
            for (int i = 0; i < shift.Length; i++)
            {
                offset += ((shift[i][0] == 0) ? -1 : 1) * shift[i][1];
            }
            offset = offset % s.Length;
            if (offset == 0)
                return s;
            else if (offset < 0)
            {
                string s1 = s.Substring(0, -offset);
                string s2 = s.Substring(-offset);
                return s2 + s1;
            }
            else
            {
                string s1 = s.Substring(s.Length - offset);
                string s2 = s.Substring(0, s.Length - offset);
                return s1 + s2;
            }
        }
    }
}
