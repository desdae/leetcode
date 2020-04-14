using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions._00700._00784
{
    public class Solution
    {
        private List<string> results = new List<string>();

        private void Perm(int pos, StringBuilder sb)
        {
            while (pos < sb.Length && Char.IsDigit(sb[pos]))
                pos++;
            if (pos < sb.Length)
            {
                sb[pos] = sb[pos].ToString().ToUpper()[0];
                Perm(pos + 1, sb);
                sb[pos] = sb[pos].ToString().ToLower()[0];
                Perm(pos + 1, sb);
            }
            else
            {
                results.Add(sb.ToString());
                return;
            }
        }
        public IList<string> LetterCasePermutation(string S)
        {

            Perm(0, new StringBuilder(S));
            return results;
        }
    }
}
