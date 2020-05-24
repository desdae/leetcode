using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._01400._01455
{
    public class Solution
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            var w = sentence.Split(' ');
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i].StartsWith(searchWord))
                    return i + 1;
            }
            return -1;
        }
    }
}
